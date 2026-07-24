using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskProgresser.Core.Models;
using TaskProgresser.Core.Services;
using TaskProgresser.WinForms.Components.Controls;
using TaskProgresser.WinForms.Forms;
using TaskProgresser.WinForms.Repositories.ApiClients;
using TaskProgresser.WinForms.UIControllers;

namespace TaskProgresser.WinForms.Forms
{
    public partial class MainForm : Form
    {
        #region --- Fields ---

        private List<TaskItem> _allTasks = new List<TaskItem>();
        private readonly TasksApiClient _tasksApiClient = new TasksApiClient();

        #endregion --- Fields ---

        #region --- Properties ---
        //private bool IsLocalStorage { get => CHB_IsLocalData.Checked; set => CHB_IsLocalData.Checked = value; }

        #endregion --- Properties ---

        #region --- Setup ---

        public MainForm()
        {
            InitializeComponent();
            ClearTasks();
            BaseApiClient.OnUnathorized += HandleUnauthorized;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tasksApiClient.GetToken()))
            {
                //MessageBox.Show("Токена нет!");
                Authorization();
            }
            else
            {
                //MessageBox.Show("Токен существует!");
                LBL_Username.Text = _tasksApiClient.GetUsername();
            }

            await LoadData();

            RenderTasks();

            ProgressUpdateController.Tick += () => Label_CurrentDateTime.Text = DateTime.Now.ToString();
            ProgressUpdateController.Start();
        }

        #endregion --- Setup ---

        #region --- Authorization ---

        private async void HandleUnauthorized(string message)
        {
            // Важно: так как событие может прилететь из асинхронного потока (HttpClient),
            // нам нужно безопасно переключиться на главный UI-поток через Invoke
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { HandleUnauthorized(message); }));
                return;
            }

            MessageBox.Show(this, message, "Помилка авторизації!");
            ClearTasks();
            Hide();
            Authorization();
            if (BaseApiClient.Token != null)
            {
                Show();
                await LoadData();
                RenderTasks();
            }
        }

        private void Authorization()
        {
            var authForm = new AuthForm();
            if (authForm.ShowDialog(this) == DialogResult.OK)
            {
                LBL_Username.Text = authForm.Username;
            }
            else Application.Exit();
        }

        #endregion --- Authorization ---

        #region --- Events Handlers ---

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Бажаєте залишити програму працювати у фоні?", "Закриття", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    e.Cancel = true;

                    this.Hide();

                    MainIcon.ShowBalloonTip(3000, "", "Програма продовжує роботу у фоновому режимі!", ToolTipIcon.Info);
                }
                else if (result == DialogResult.Cancel) e.Cancel = true;
            }
        }

        private async void BTN_Add_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditTaskForm();
            if (addForm.ShowDialog() == DialogResult.OK)
                await AddTask(addForm.Task);
            addForm.Close();
        }

        private void ToolStripMenuItem_OpenMainWindow_Click(object sender, EventArgs e) => RestoreWindow();

        private void ToolStripMenuItem_CloseApp_Click(object sender, EventArgs e) => Application.Exit();

        private void MainIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible) this.Hide();
            else RestoreWindow();
        }

        private async void CHB_IsLocalData_CheckedChangedAsync(object sender, EventArgs e)
        {
            // if (this.InvokeRequired) throw new Exception("Invoke required failed!");

            await LoadData();
            //if (this.InvokeRequired) throw new Exception ("Invoke required failed!");

            RenderTasks();
        }

        private async void BTN_Logout_Click(object sender, EventArgs e)
        {
            Hide();
            ClearTasks();
            _tasksApiClient.ResetToken();
            Authorization();
            await LoadData();
            RenderTasks();
            Show();
        }

        private async void BTN_Update_Click(object sender, EventArgs e)
        {
            ClearTasks();
            await LoadData();
            RenderTasks();
        }

        private async void BTN_Statistics_Click(object sender, EventArgs e)
        {
            Hide();
            new StatisticsForm().ShowDialog(this);
            Show();
            ClearTasks();
            await LoadData();
            RenderTasks();
        }

        #endregion --- Events Handlers ---

        #region --- Task Control --- (move to a separate class)

        private async Task AddTask(TaskItem newTask)
        {
            try
            {
                BlockUI();
                await _tasksApiClient.AddTaskAsync(newTask);
                _allTasks = _allTasks.Prepend(newTask).ToList();
                RenderTasks();
                UnblockUI();
                Invoke(new Action(() => { MessageBox.Show(this, "Додавання успішне!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information); }));
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            finally
            {
                UnblockUI();
            }
        }

        private async void UpdateTask(TaskItem task)
        {
            if (task != null)
            {
                try
                {
                    BlockUI();
                    await _tasksApiClient.UpdateTaskAsync(task);
                    RenderTasks();
                    UnblockUI();
                    Invoke(new Action(() => { MessageBox.Show(this, "Дані успішно оновлені!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information); }));
                }
                catch (Exception ex) { Debug.WriteLine(ex.Message); }
                finally
                {
                    UnblockUI();
                }
            }
        }

        private async void DeleteTask(TaskItem taskToRemove)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити задачу?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    BlockUI();
                    await _tasksApiClient.DeleteTaskAsync(taskToRemove.Id);
                    _allTasks.Remove(taskToRemove);
                    RenderTasks();
                    UnblockUI();
                    Invoke(new Action(() => { MessageBox.Show(this, "Видалення успішне!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information); }));
                }
                catch (Exception ex) { Debug.WriteLine(ex.Message); }
                finally
                {
                    UnblockUI();
                }
            }
        }

        private async void CompleteTask(TaskItem task)
        {
            try
            {
                if (!task.IsCompleted)
                {
                    if (MessageBox.Show("Ви дійсно хочете завершити задачу?", "Підтвердженя операції!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BlockUI();
                        task.CompletedAt = DateTime.Now;
                        await _tasksApiClient.UpdateTaskAsync(task);
                        RenderTasks();
                        UnblockUI();
                        Invoke(new Action(() => { MessageBox.Show(this, $"Задачу успішно виконано за {TaskAnalyticsController.CalculateEfficiency(task)}% часу!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.None); }));
                    }
                }
                else if (MessageBox.Show("Ви дійсно хочете скасувати виконання задачі?", "Підтвердженя операції!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BlockUI();
                    task.CompletedAt = null;
                    await _tasksApiClient.UpdateTaskAsync(task);
                    RenderTasks();
                    UnblockUI();
                    Invoke(new Action(() => { MessageBox.Show(this, $"Задачу додано в активні!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.None); }));
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            finally { UnblockUI(); }
        }

        #endregion --- Task Control ---

        #region --- Work with data ---

        private async Task LoadData()
        {
            BlockUI();
            try { _allTasks = await _tasksApiClient.GetAllTasksAsync(); }
            catch (Exception ex) { Debug.WriteLine(ex.Message); } // { Invoke(new Action(() => MessageBox.Show(this, ex.Message, "Помилка при завантаженні задач!"))); }
            UnblockUI();
        }

        #endregion --- Work with data ---

        #region --- Visual ---

        private void UpdateWidthForTaskControls()
        {
            FlowPanel_Active.SuspendLayout();
            FlowPanel_Completed.SuspendLayout();

            int active_margin = 12;
            int completed_margin = 12;

            // FIX - если больше двух задач, отступ меняется (костыль, надо переделать)
            if (FlowPanel_Active.Controls.Count > 2) active_margin = 30;
            if (FlowPanel_Completed.Controls.Count > 2) completed_margin = 30;

            foreach (Control control in FlowPanel_Active.Controls)
                control.Width = FlowPanel_Active.ClientSize.Width - active_margin;

            foreach (Control control in FlowPanel_Completed.Controls)
                control.Width = FlowPanel_Completed.ClientSize.Width - completed_margin;

            FlowPanel_Active.ResumeLayout();
            FlowPanel_Completed.ResumeLayout();
        }

        private void RenderTasks()
        {
            this.Invoke(new Action(() =>
            {

                ClearTasks();

                FlowPanel_Active.SuspendLayout();
                FlowPanel_Completed.SuspendLayout();

                foreach (var taskModel in _allTasks)
                {
                    TaskControl taskControl = new TaskControl(taskModel);
                    taskControl.TaskEdited += UpdateTask;
                    taskControl.TaskDeleted += DeleteTask;
                    taskControl.TaskCompleted += CompleteTask;

                    if (taskModel.IsCompleted)
                        FlowPanel_Completed.Controls.Add(taskControl);
                    else
                        FlowPanel_Active.Controls.Add(taskControl);
                }

                UpdateWidthForTaskControls();

                FlowPanel_Active.ResumeLayout();
                FlowPanel_Completed.ResumeLayout();
            }));
        }

        private void ClearTasks()
        {
            FlowPanel_Active.SuspendLayout();
            FlowPanel_Completed.SuspendLayout();

            while (FlowPanel_Active.Controls.Count > 0)
                FlowPanel_Active.Controls[0]?.Dispose();

            while (FlowPanel_Completed.Controls.Count > 0)
                FlowPanel_Completed.Controls[0]?.Dispose();

            FlowPanel_Active.Controls.Clear();
            FlowPanel_Completed.Controls.Clear();

            FlowPanel_Active.ResumeLayout();
            FlowPanel_Completed.ResumeLayout();
        }

        private void RestoreWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            BringToFront();
        }

        private void BlockUI()
        {
            WaitingForm.ShowWaitingForm(this);
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
        }

        private void UnblockUI()
        {
            WaitingForm.CloseWaitingForm();
            this.Enabled = true;
            this.Cursor = Cursors.Default;
            BringToFront();
        }


        #endregion --- Visual ---

    }
}
