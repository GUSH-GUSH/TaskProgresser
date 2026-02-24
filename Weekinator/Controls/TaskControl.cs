using CourseWork.Forms;
using DateTimeToolKit.Models.DateRange;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Weekinator.Controls;
using Weekinator.Models;

namespace Weekinator.Forms.UserControls
{
    public partial class TaskControl : ClickableUserControl
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
                }
                else SetupDefaultValue();
            }
        }

        public string Title
        {
            get => GroupBox.Text;
            set => GroupBox.Text = value;
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

        #endregion

        #region --- SETUP ---

        public TaskControl()
        {
            InitializeComponent();
            Task = new TaskItem();
        }

        public TaskControl(TaskItem task) : this() {
            Setup(task);
            DateRangeControl.OnValueChanged += (o,e) => Debug.WriteLine("ValueChanged");
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {
            NUD_Precision.Value = DateRangeControl.Precision;
        }

        public void Setup(TaskItem task) => Task = task;

        private void SetupDefaultValue() {
            Title = "Назва";
            DateRange = DateRangeControl.DefaultDateRange;
            CHB_AddToTray.Checked = false;
            NUD_Precision.Value = 3;
        }

        #endregion

        #region --- EVENTS HANDLERS ---

        private void NUD_Accurancy_ValueChanged(object sender, EventArgs e)
        {
            Task.Precision = DateRangeControl.Precision = (byte)NUD_Precision.Value;
            TaskEdited?.Invoke(null);
        }

        private void BTN_GetInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStatistics());
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (new AddEditTaskForm(Task).ShowDialog() == DialogResult.OK) {
                TaskEdited?.Invoke(Task);
            }
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

        #endregion

        #region --- DEBUG ---

        private string GetStatistics()
        {
            double precentPerSecond = 100.0 / DateRangeControl.DateRange.Length.TotalSeconds;
            double precentPerMinute = 100.0 / DateRangeControl.DateRange.Length.TotalMinutes;
            double precentPerDay = 100.0 / DateRangeControl.DateRange.Length.TotalDays;
            double precentPerWeek = 100.0 / DateRangeControl.DateRange.TotalWeeks;

            return $"Процент в секунду = {precentPerSecond.ToString("F6")}\n" +
                   $"Процент в минуту = {precentPerMinute.ToString("F6")}\n" +
                   $"Процент в день = {precentPerDay.ToString("F6")}\n" +
                   $"Процент в неделю = {precentPerWeek.ToString("F6")}";
        }

        void debug_info(DateRange dateRange, DateTime point)
        {

            Debug.WriteLine($"Range: {dateRange}");
            Debug.WriteLine($"Date: {point}");
            Debug.WriteLine($"Day of semester: {dateRange.GetDayOf(point)}/{dateRange.TotalDays}");
            Debug.WriteLine($"Num of week: {dateRange.GetWeekOf(point)}/{dateRange.TotalWeeks}");
            Debug.WriteLine($"Day of week: {point.DayOfWeek}");
            Debug.WriteLine($"Total precent: {Math.Round(dateRange.GetFractionOf(point) * 100, 3)}%");
            Debug.WriteLine($"Week mark: " + ((dateRange.GetWeekOf(point) % 2 == 0) ? "Znamenyk" : "Chiselnyk"));

        }

        #endregion

        #region --- EVENTS ---

        public event Action<TaskItem> TaskDeleted;
        public event Action<TaskItem> TaskCompleted;
        public event Action<TaskItem> TaskEdited;

        #endregion

 
    }
}
