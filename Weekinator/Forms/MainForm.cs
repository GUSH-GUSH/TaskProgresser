using CourseWork.Forms;
using DateTimeToolKit.Models.DateRange;
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
using Weekinator.Forms;
using Weekinator.Forms.UserControls;
using Weekinator.Models;
using Weekinator.Repositories;
using Weekinator.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Weekinator
{
    public partial class MainForm : Form
    {
        #region --- Fields ---

        private List<TaskItem> _allTasks = new List<TaskItem>();
        
        #endregion

        #region --- Setup ---

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            ProgressUpdaterService.Tick += () => Label_CurrentDateTime.Text = DateTime.Now.ToString();
            ProgressUpdaterService.Start();
        }

        private void LoadData()
        {
            _allTasks = JsonTaskSeializer.LoadTasks();
            RenderTasks();
        }

        #endregion

        #region--- Events Handlers ---

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
            this.Visible = false;
        }

        private void BTN_OpenTestIconForm_Click(object sender, EventArgs e)
        {
            new Forms.DebugForms.TextIconTestForm().Show(this);
        }

        private void BTN_Save_Click(object sender, EventArgs e) => SaveAllData();

        private void BTN_Load_Click(object sender, EventArgs e) => LoadData();
        
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditTaskForm();
            if (addForm.ShowDialog() == DialogResult.OK)
                AddTask(addForm.Task);
            addForm.Close();
        }

        //private void TSKCTRL_Semestr_DoubleClick(object sender, EventArgs e)
        //{
        //    Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

        //    TrayFlayoutTaskForm _flyoutForm = new TrayFlayoutTaskForm(new Models.TaskItem()
        //    {
        //        Title = TSKCTRL_Semestr.Title,
        //        StartDate = TSKCTRL_Semestr.DateRange.Start,
        //        EndDate = TSKCTRL_Semestr.DateRange.End,
        //    });

        //    int x = workingArea.Right - _flyoutForm.Width;
        //    int y = workingArea.Bottom - _flyoutForm.Height;

        //    _flyoutForm.Location = new Point(x, y);

        //    _flyoutForm.Show();
        //    _flyoutForm.Activate();
        //}

        #endregion

        #region --- Task Control --- (move to a separate class)

        private void AddTask(TaskItem newTask)
        {
            _allTasks = _allTasks.Prepend(newTask).ToList();
            RenderTasks();
            SaveAllData();
            MessageBox.Show("Додавання успішне!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTask(TaskItem task) {
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
                    MessageBox.Show($"Задачу успішно виконано за {task.EfficiencyPercentage}% часу!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        void SaveAllData() {
            JsonTaskSeializer.SaveTasks(_allTasks);
        }

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
            FlowPanel_Active.SuspendLayout();
            FlowPanel_Completed.SuspendLayout();

            while (FlowPanel_Active.Controls.Count > 0)
                FlowPanel_Active.Controls[0].Dispose();
            
            while (FlowPanel_Completed.Controls.Count > 0)
                FlowPanel_Completed.Controls[0].Dispose();

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


                UpdateWidthForTaskControls();

                FlowPanel_Active.ResumeLayout();
                FlowPanel_Completed.ResumeLayout();
            }
        }

        #endregion

    }
}
