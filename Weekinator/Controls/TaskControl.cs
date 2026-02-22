using DateTimeToolKit.Models.DateRange;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Weekinator.Controls;

namespace Weekinator.Forms.UserControls
{
    public partial class TaskControl : ClickableUserControl
    {
        public string Title
        {
            get => GroupBox.Text;
            set => GroupBox.Text = value;
        }

        public DateRange DateRange {
            get => DateRangeControl.DateRange;
            set => DateRangeControl.DateRange = value;
        }

        public DateTime Start {
            get => DateRangeControl.DateRange.Start;
            set => DateRangeControl.SetDateRange(value, End);
        }

        public DateTime End
        {
            get => DateRangeControl.DateRange.End;
            set => DateRangeControl.DateRange.SetDateRange(Start, value);
        }


        #region --- SETUP ---

        public TaskControl()
        {
            InitializeComponent();
        }
        private void TaskControl_Load(object sender, EventArgs e)
        {
            NUD_Accurancy.Value = DateRangeControl.Precision;
        }

        #endregion


        #region --- EVENTS ---

        private void NUD_Accurancy_ValueChanged(object sender, EventArgs e)
        {
            DateRangeControl.Precision = (byte)NUD_Accurancy.Value;
        }

        private void BTN_GetInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStatistics());
        }

        #endregion


        #region --- SAVE TO FILE ---

        /*
private void button1_Click(object sender, EventArgs e)
{
string result = JsonSerializer.Serialize(DateRangeControl.DateRange, new JsonSerializerOptions() { WriteIndented = true });

if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

using (FileStream stream = new FileStream(Path.Combine(directory, file), FileMode.OpenOrCreate))
using (StreamWriter streamWriter = new StreamWriter(stream))
    streamWriter.WriteLine(result);

MessageBox.Show($"Диапазон успешно сохранён!");
}

private void LoadData()
{
if (!File.Exists(Path.Combine(directory, file))) return;

using (StreamReader streamReader = new StreamReader(Path.Combine(directory, file)))
{
    DateRangeControl.DateRange = JsonSerializer.Deserialize<DateRange>(streamReader.ReadToEnd());
}

}

string directory = "user-data";
string file = "date-range.json";
*/
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

    }
}
