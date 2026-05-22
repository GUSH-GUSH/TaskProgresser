using CourseWork.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskProgresser.WinForms.Forms;
using TaskProgresser.WinForms.Forms.UserControls;
using TaskProgresser.WinForms.Repositories;
using TaskProgresser.WinForms.ApiClients;

using TaskProgresser.Core.Models;
using TaskProgresser.Core.Services;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Interop;

namespace TaskProgresser.WinForms
{
    public partial class MainForm : Form
    {
        #region --- Fields ---

        private List<TaskItem> _allTasks = new List<TaskItem>();
        private readonly TasksApiClient _tasksApiClient = new TasksApiClient();

        #endregion

        #region --- Properties ---
        private bool IsLocalStorage { get => CHB_IsLocalData.Checked; set => CHB_IsLocalData.Checked = value; }

        #endregion --- Properties ---

        #region --- Setup ---

        public MainForm()
        {
            InitializeComponent();
            Autorization();
        }

        private void Autorization()
        {
            var authForm = new AuthForm();
            if (authForm.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(authForm.Token);
                MessageBox.Show(BaseApiClient.Token);
            }
            else Application.Exit();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadData();
            RenderTasks();

            ProgressUpdaterService.Tick += () => Label_CurrentDateTime.Text = DateTime.Now.ToString();
            ProgressUpdaterService.Start();
        }

        #endregion

        #region--- Events Handlers ---

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

        private void BTN_OpenTestIconForm_Click(object sender, EventArgs e)
        {
            new Forms.DebugForms.TextIconTestForm().Show(this);
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditTaskForm();
            if (addForm.ShowDialog() == DialogResult.OK)
                AddTask(addForm.Task);
            addForm.Close();
        }

        private void ToolStripMenuItem_OpenMainWindow_Click(object sender, EventArgs e) => RestoreWindow();

        private void ToolStripMenuItem_CloseApp_Click(object sender, EventArgs e) => Application.Exit();

        private void MainIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible) this.Hide();
            else RestoreWindow();
        }

        #endregion

        #region --- Task Control --- (move to a separate class)

        private void AddTask(TaskItem newTask)
        {
            _allTasks = _allTasks.Prepend(newTask).ToList();
            RenderTasks();
            SaveAllData();
            MessageBox.Show("Додавання успішне!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTask(TaskItem task)
        {
            SaveAllData();
            if (task != null)
            {
                RenderTasks();
                MessageBox.Show("Дані успішно оновлені!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteTask(TaskItem taskToRemove)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити задачу?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _allTasks.Remove(taskToRemove);
                RenderTasks();
                SaveAllData();
                MessageBox.Show("Видалення успішне!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CompleteTask(TaskItem task)
        {
            if (!task.IsCompleted)
            {
                if (MessageBox.Show("Ви дійсно хочете завершити задачу?", "Підтвердженя операції!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    task.CompletedAt = DateTime.Now;
                    RenderTasks();
                    SaveAllData();
                    MessageBox.Show($"Задачу успішно виконано за {TaskAnalyticsService.CalculateEfficiency(task)}% часу!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else if (MessageBox.Show("Ви дійсно хочете скасувати виконання задачі?", "Підтвердженя операції!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                task.CompletedAt = null;
                RenderTasks();
                SaveAllData();
                MessageBox.Show($"Задачу додано в активні!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }


        #endregion

        #region --- Work with data ---

        private async Task LoadData()
        {
            if (IsLocalStorage) _allTasks = JsonTaskSeializer.LoadTasks();
            else
            {
                try { _allTasks = await _tasksApiClient.GetAllTasksAsync(); }
                catch (Exception ex) { MessageBox.Show(this, ex.Message, "Помилка при завантаженні задач!"); }
            }
        }

        private async void SaveAllData()
        {
            if (IsLocalStorage) JsonTaskSeializer.SaveTasks(_allTasks);
            //else await TasksApiClient.(_allTasks);
        }

        #endregion

        #region --- Visual ---

        private void UpdateWidthForTaskControls()
        {
            FlowPanel_Active.SuspendLayout();
            FlowPanel_Completed.SuspendLayout();

            int margin = 12;

            foreach (Control control in FlowPanel_Active.Controls)
                control.Width = FlowPanel_Active.ClientSize.Width - margin;

            foreach (Control control in FlowPanel_Completed.Controls)
                control.Width = FlowPanel_Completed.ClientSize.Width - margin;

            FlowPanel_Active.ResumeLayout();
            FlowPanel_Completed.ResumeLayout();
        }

        private void RenderTasks()
        {
        //    if (this.InvokeRequired) throw new Exception ("Invoke required failed!");

            this.Invoke(new Action(() =>
            {

                FlowPanel_Active.SuspendLayout();
                FlowPanel_Completed.SuspendLayout();

                while (FlowPanel_Active.Controls.Count > 0)
                {
                    var currentControl = FlowPanel_Active.Controls[0];
                    FlowPanel_Active.Controls.Remove(currentControl);
                    currentControl.Dispose();
                }

                while (FlowPanel_Completed.Controls.Count > 0)
                {
                    var currentControl = FlowPanel_Completed.Controls[0];
                    FlowPanel_Completed.Controls.Remove(currentControl);
                    currentControl.Dispose();
                }


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

        private void RestoreWindow()
        {
            this.Show(); // Показываем форму
            this.WindowState = FormWindowState.Normal; // Восстанавливаем размер
            this.Activate(); // Выводим на передний план
        }

        #endregion

        private async void CHB_IsLocalData_CheckedChangedAsync(object sender, EventArgs e)
        {
           // if (this.InvokeRequired) throw new Exception("Invoke required failed!");

            await LoadData();
            //if (this.InvokeRequired) throw new Exception ("Invoke required failed!");

            RenderTasks();
        }
    }
}
