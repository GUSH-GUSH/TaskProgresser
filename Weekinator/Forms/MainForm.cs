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

            ProgressUpdaterService.Start();
        }

        private void LoadData()
        {
            _allTasks = JsonTaskSeializer.LoadTasks();
            RenderTasks();
        }

        #endregion

        #region --- Events ---

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

        private void TSKCTRL_Semestr_DoubleClick(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            TrayFlayoutTaskForm _flyoutForm = new TrayFlayoutTaskForm(new Models.TaskItem()
            {
                Title = TSKCTRL_Semestr.Title,
                StartDate = TSKCTRL_Semestr.DateRange.Start,
                EndDate = TSKCTRL_Semestr.DateRange.End,
            });

            int x = workingArea.Right - _flyoutForm.Width;
            int y = workingArea.Bottom - _flyoutForm.Height;

            _flyoutForm.Location = new Point(x, y);

            _flyoutForm.Show();
            _flyoutForm.Activate();
        }

        #endregion

        #region --- Task Control --- (move to a separate class)

        private void AddTask(TaskItem newTask)
        {
            _allTasks.Add(newTask);
            RenderTasks(); // Обновляем UI
            SaveAllData(); // Сразу пишем в файл
        }

        private void DeleteTask(TaskItem taskToRemove)
        {
            _allTasks.Remove(taskToRemove);
            RenderTasks();
            SaveAllData(); // Сразу пишем в файл
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

            // Пробегаемся по всем элементам внутри панели FlowPanel_Active
            foreach (Control control in FlowPanel_Active.Controls)
                control.Width = FlowPanel_Active.ClientSize.Width - margin;

            // Пробегаемся по всем элементам внутри панели FlowPanel_Completed
            foreach (Control control in FlowPanel_Completed.Controls)
                control.Width = FlowPanel_Completed.ClientSize.Width - margin;

            // Включаем перерисовку обратно
            FlowPanel_Active.ResumeLayout();
            FlowPanel_Completed.ResumeLayout();
        }

        // Метод, который отрисовывает задачи на экране
        private void RenderTasks()
        {
            FlowPanel_Active.SuspendLayout();
            FlowPanel_Completed.SuspendLayout();

            // (По-хорошему тут еще нужно вызывать .Dispose() для старых контролов, но для MVP пока оставим так)
            FlowPanel_Active.Controls.Clear();
            FlowPanel_Completed.Controls.Clear();

            foreach (var taskModel in _allTasks)
            {
                TaskControl taskControl = new TaskControl(taskModel);

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
