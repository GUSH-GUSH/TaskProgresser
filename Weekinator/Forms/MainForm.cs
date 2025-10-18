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
        private System.Windows.Forms.Timer timer;

        public enum WeekMark {
            Numerator,      //Числитель
            Denominator     //Знаменатель
        }

        private readonly Dictionary<WeekMark, Icon> WeekMarkIcons;


        public MainForm()
        {
            InitializeComponent();

            Font iconFont = new Font("Arial Black", 24, FontStyle.Bold);
            WeekMarkIcons = new Dictionary<WeekMark, Icon> {
                { WeekMark.Numerator, IconGenerator.GetIcon("Ч", iconFont, new Size (32, 32)) },
                { WeekMark.Denominator, IconGenerator.GetIcon("З", iconFont, new Size (32, 32)) }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*SetDateRange(new DateTime(2025, 02, 03), new DateTime(2025, 06, 23));

            DateTime point = DateTime.Now;
            
            Debug.WriteLine("");

            Debug.WriteLine($"Range: {dateRange}");
            Debug.WriteLine($"Date: {point}");
            Debug.WriteLine($"Day of semester: {dateRange.GetDayOf(point)}/{dateRange.TotalDays}");
            Debug.WriteLine($"Num of week: {dateRange.GetWeekOf(point)}/{dateRange.TotalWeeks}");
            Debug.WriteLine($"Day of week: {point.DayOfWeek}");
            Debug.WriteLine($"Total precent: {Math.Round(dateRange.GetFractionOf(point) * 100, 3)}%");
            Debug.WriteLine($"Week mark: " + ((dateRange.GetWeekOf(point) % 2 == 0) ? "Znamenyk" : "Chiselnyk"));

            //fract = dateRange.GetFractionOf(point);

            //UpdatePrecentLabelText();
            //UpdatePrecentLabelLocation();
            //UpdateMainProgressBarValue();
            //int count = 0;

            dateRangeControl1.SetDateRange(dateRange);

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (obj, eventArgs) => {
                dateRangeControl1.GetFractionOf(DateTime.Now);
                Update();
                label_update();
            };
            timer.Start();*/

            DateTime start = new DateTime(2025, 09, 01, 8, 0, 0);
            DateTime end = new DateTime(2025, 12, 19, 17, 0, 0);
            DateRange dateRange = new DateRange(start, end);


            DateRangeControl.SetDateRange(dateRange);
            DateRangeControl.UpdateValue(DateTime.Now);

            //LoadData();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += (obj, eventArgs) => UpdateTimers();
            timer.Start();

            Precision_NumericUpDown.Value = DateRangeControl.Precision;

            UpdateWeekmarkIcon();

        }

        public void UpdateTimers() {
            DateRangeControl.UpdateValue(DateTime.Now);
            UpdateIcon();
            CurrentDateTime_Label.Text = DateTime.Now.ToString();
        }

        public void UpdateIcon()
        {
            double precent = DateRangeControl.Precent;
            Precent_Icon.Text = $"Текущий процент - {precent}%\n\n";

            double roundedPrecent = Math.Round(precent, 1);
            Precent_Icon.Icon?.Dispose();
            Precent_Icon.Icon = IconGenerator.GetDefaultIcon(roundedPrecent.ToString());
        }

        public void UpdateWeekmarkIcon() {
            DateRange dateRange = DateRangeControl.DateRange;
            int currentWeek = dateRange.GetWeekOf(DateTime.Now);
            int totalWeeks = dateRange.TotalWeeks;
            WeekMark_Icon.Text = $"Неделя {currentWeek} из {totalWeeks}";

            WeekMark weekMark = currentWeek % 2 == 1 ? WeekMark.Numerator : WeekMark.Denominator;
            WeekMark_Icon.Icon?.Dispose();
            WeekMark_Icon.Icon = WeekMarkIcons[weekMark];
        }

        private void openTestIconForm_Button_Click(object sender, EventArgs e)
        {
            new Forms.DebugForms.TextIconTestForm().Show(this);
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
            this.Visible = false;
            
        }

        private void PrecentIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible == true)
            {
                this.Hide();
                //WeekMark_Icon.ShowBalloonTip(5000, "Weekinator активен!", "Приложение работает в фоновом режиме!", ToolTipIcon.None);
            }
            else this.Show();
        }

        private void IconMainMenu_CloseItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMainMenu_OpenItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void Precission_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DateRangeControl.Precision = (byte)Precision_NumericUpDown.Value;
        }

        private string GetStatistics() {
            double precentPerSecond = 100.0 / DateRangeControl.DateRange.Length.TotalSeconds;
            double precentPerMinute = 100.0 / DateRangeControl.DateRange.Length.TotalMinutes;
            double precentPerDay = 100.0 / DateRangeControl.DateRange.Length.TotalDays;
            double precentPerWeek = 100.0 / DateRangeControl.DateRange.TotalWeeks;

            return $"Процент в секунду = {precentPerSecond.ToString("F6")}\n" +
                   $"Процент в минуту = {precentPerMinute.ToString("F6")}\n" +
                   $"Процент в день = {precentPerDay.ToString("F6")}\n" +
                   $"Процент в неделю = {precentPerWeek.ToString("F6")}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStatistics());
        }


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
