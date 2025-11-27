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
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Weekinator.Services;

namespace Weekinator
{
    public partial class MainForm : Form
    {
        #region --- fields ---

        private System.Windows.Forms.Timer timer;

        #endregion


        #region --- setup ---

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime start = new DateTime(2025, 09, 01, 8, 0, 0);
            DateTime end = new DateTime(2025, 12, 19, 17, 0, 0);
            DateRange dateRange = new DateRange(start, end);


            DateRangeControl.SetDateRange(dateRange);
            DateRangeControl.UpdateValue(DateTime.Now);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += (obj, eventArgs) => UpdateTimers();
            timer.Start();

            Precision_NumericUpDown.Value = DateRangeControl.Precision;

            IconsSetup();
        }

        private void IconsSetup() {
            DateRangeControl.PrecentIcon.MouseDoubleClick += PrecentIcon_MouseDoubleClick;
            DateRangeControl.WeekMarkIcon.MouseDoubleClick += PrecentIcon_MouseDoubleClick;

            DateRangeControl.IconMainMenu_CloseItem.Click += IconMainMenu_CloseItem_Click;
            DateRangeControl.IconMainMenu_OpenItem.Click += IconMainMenu_OpenItem_Click;
        }

        #endregion


        #region --- timer ---

        public void UpdateTimers()
        {
            DateRangeControl.UpdateValue(DateTime.Now);
            CurrentDateTime_Label.Text = DateTime.Now.ToString();
        }

        #endregion


        #region --- events ---

        #region --- events_icons ---

        private void PrecentIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible == true)
            {
                this.Hide();
                //WeekMark_Icon.ShowBalloonTip(5000, "Weekinator активен!", "Приложение работает в фоновом режиме!", ToolTipIcon.None);
            }
            else this.Show();


        }

        private void IconMainMenu_CloseItem_Click(object sender, EventArgs e) => Application.Exit();
        private void IconMainMenu_OpenItem_Click(object sender, EventArgs e) => Show();

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
            this.Visible = false;
        }

        private void openTestIconForm_Button_Click(object sender, EventArgs e)
        {
            new Forms.DebugForms.TextIconTestForm().Show(this);
        }

        private void Precission_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DateRangeControl.Precision = (byte)Precision_NumericUpDown.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStatistics());
        }

        #endregion


        #region --- debug ---

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
    }
}
