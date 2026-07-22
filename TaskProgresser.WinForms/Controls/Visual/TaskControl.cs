using CourseWork.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TaskProgresser.WinForms.Controls;
using TaskProgresser.Core.Models;
using TaskProgresser.Core.Services;
using TaskProgresser.WinForms.Components;

namespace TaskProgresser.WinForms.Forms.UserControls
{
    public partial class TaskControl : ClickableUserControl, IDisposable
    {

        #region --- Fields ---

        private TaskItem _task;

        #endregion

        #region --- Properties ---

        public TaskItem Task
        {
            get => _task;
            set
            {
                _task = value;

                if (value != null)
                {

                    Title = Task.Title;
                    DateRange = new DateRange(Task.StartDate, Task.EndDate);
                    CHB_AddToTray.Checked = Task.ShowInTray;
                    NUD_Precision.Value = Task.Precision;
                    DateRangeControl.RangeName = Task.Title;
                    ApplyVisualState();
                }
                else SetupDefaultValue();
            }
        }

        public string Title
        {
            get => LBL_Title.Text;
            set => LBL_Title.Text = value;
        }

        public DateRange DateRange
        {
            get => DateRangeControl.DateRange;
            set => DateRangeControl.DateRange = value;
        }

        public DateTime Start
        {
            get => DateRangeControl.DateRange.Start;
            set => DateRangeControl.SetDateRange(value, End);
        }

        public DateTime End
        {
            get => DateRangeControl.DateRange.End;
            set => DateRangeControl.DateRange.SetDateRange(Start, value);
        }

        public TaskAnalyticsService.TaskState TaskState { get; private set; }

        #endregion

        #region --- SETUP ---

        public TaskControl()
        {
            InitializeComponent();
            Task = new TaskItem();
        }

        public TaskControl(TaskItem task) : this()
        {
            Setup(task);
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {
            NUD_Precision.Value = DateRangeControl.Precision;
            DateRangeControl.HideIcon += () =>
            {
                CHB_AddToTray.Checked = false;
            };
            ProgressUpdateController.Tick += ApplyVisualState;
        }

        public void Setup(TaskItem task) => Task = task;

        private void SetupDefaultValue()
        {
            Title = "Назва";
            DateRange = DateRangeControl.DefaultDateRange;
            DateRangeControl.RangeName = Title;
            CHB_AddToTray.Checked = false;
            NUD_Precision.Value = 3;
            ApplyVisualState();
        }

        public new void Dispose() {
            ProgressUpdateController.Tick -= ApplyVisualState;
            base.Dispose();
        }
        #endregion

        #region --- EVENTS HANDLERS ---

        private void NUD_Accurancy_ValueChanged(object sender, EventArgs e)
        {
            if (Task == null) return;
            Task.Precision = DateRangeControl.Precision = (byte)NUD_Precision.Value;
            if (Task.IsCompleted) UpdateCompletePrecentage();
            TaskEdited?.Invoke(null);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new AddEditTaskForm(Task);
            if (editForm.ShowDialog() == DialogResult.OK) TaskEdited?.Invoke(Task);
            editForm.Close();
        }
        private void BTN_Complete_Click(object sender, EventArgs e)
        {
            TaskCompleted?.Invoke(Task);
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            TaskDeleted?.Invoke(Task);
        }
        private void CHB_AddToTray_CheckedChanged(object sender, EventArgs e)
        {
            DateRangeControl.EnableIcon = Task.ShowInTray = CHB_AddToTray.Checked;
            TaskEdited?.Invoke(null);
        }

        private void DateRangeControl_IconClick()
        {
            var trayForm = new TrayFlayoutTaskForm(Task);
            trayForm.Show();
            trayForm.Activate();
        }

        #endregion

        #region --- EVENTS ---

        public event Action<TaskItem> TaskDeleted;
        public event Action<TaskItem> TaskCompleted;
        public event Action<TaskItem> TaskEdited;

        #endregion

        #region --- VISUAL ---

        private void ApplyVisualState()
        {
            if (Task == null) return;

            var taskState = TaskAnalyticsService.GetState(Task, DateTime.Now);

            if (taskState == TaskState) return;

            TaskState = taskState;

            LBL_Status.Text = TaskAnalyticsService.TaskStateTitles[taskState];

            switch (taskState)
            {
                case TaskAnalyticsService.TaskState.NotStarted:
                    ResultPanel.Visible = false;
                    CHB_AddToTray.Visible = true;
                    BTN_Complete.Text = "Виконати";
                    BTN_Complete.Enabled = false;
                    BTN_Complete.ForeColor = Color.Green;
                    DateRangeControl.AutoUpdate = true;
                    LBL_Status.ForeColor = Color.Black;
                    break;
                case TaskAnalyticsService.TaskState.InProgress:
                    ResultPanel.Visible = false;
                    CHB_AddToTray.Visible = true;
                    BTN_Complete.Text = "Виконати";
                    BTN_Complete.Enabled = true;
                    BTN_Complete.ForeColor = Color.Green;
                    DateRangeControl.AutoUpdate = true;
                    LBL_Status.ForeColor = Color.Green;
                    break;
                case TaskAnalyticsService.TaskState.Overduing:
                    ResultPanel.Visible = false;
                    CHB_AddToTray.Visible = true;
                    BTN_Complete.Text = "Виконати";
                    BTN_Complete.Enabled = true;
                    BTN_Complete.ForeColor = Color.Red;
                    DateRangeControl.AutoUpdate = true;
                    LBL_Status.ForeColor = Color.Red;
                    break;
                case TaskAnalyticsService.TaskState.CompletedOvertime:
                    ResultPanel.Visible = true;
                    CHB_AddToTray.Visible = false;
                    BTN_Complete.Text = "Скасувати виконання";
                    BTN_Complete.ForeColor = Color.Black;
                    DateRangeControl.AutoUpdate = false;
                    DateRangeControl.EnableIcon = false;
                    Lbl_CompletedAt.Text = $"Дата виконання: {Task.CompletedAt?.ToString("g")}";
                    LBL_Еfficiency.ForeColor = Color.Red;
                    LBL_Status.ForeColor = Color.Red;
                    UpdateCompletePrecentage();
                    break;
                case TaskAnalyticsService.TaskState.CompletedInTime:
                    ResultPanel.Visible = true;
                    CHB_AddToTray.Visible = false;
                    BTN_Complete.Text = "Скасувати виконання";
                    BTN_Complete.ForeColor = Color.Black;
                    DateRangeControl.AutoUpdate = false;
                    DateRangeControl.EnableIcon = false;
                    Lbl_CompletedAt.Text = $"Дата виконання: {Task.CompletedAt?.ToString("g")}";
                    LBL_Еfficiency.ForeColor = Color.Green;
                    LBL_Status.ForeColor = Color.Green;
                    UpdateCompletePrecentage();
                    break;
            }
            /*
            if (Task?.IsCompleted ?? false) // CHACK: Task may be not null
            {
                // --- РЕЖИМ ВИКОНАНОЇ ЗАДАЧІ ЗАДАЧИ ---
                ResultPanel.Visible = true;
                CHB_AddToTray.Visible = false;
                BTN_Complete.Text = "Скасувати виконання";
                BTN_Complete.ForeColor = Color.Black;
                DateRangeControl.AutoUpdate = false;
                DateRangeControl.EnableIcon = false;
                Lbl_CompletedAt.Text = $"Дата виконання: {Task.CompletedAt?.ToString("g")}";
                UpdateCompletePrecentage();
            }
            else
            {
                // --- РЕЖИМ АКТИВНОЇ ЗАДАЧІ ---
                ResultPanel.Visible = false;
                CHB_AddToTray.Visible = true;
                BTN_Complete.Text = "Виконати";
                BTN_Complete.ForeColor = Color.Green;
                DateRangeControl.AutoUpdate = true;
            }*/
        }

        void UpdateCompletePrecentage()
        {
            var duingPrecentage = TaskAnalyticsService.CalculateEfficiency(Task);

            LBL_Еfficiency.Text = $"Виконано за {duingPrecentage}% часу";
        }

        #endregion

    }
}
