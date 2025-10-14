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

        public MainForm()
        {
            InitializeComponent();
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

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += (obj, eventArgs) => UpdateTimers();
            timer.Start();
        }

        public void UpdateTimers() {
            DateRangeControl.UpdateValue(DateTime.Now);
            UpdateIcon();
        }

        public void UpdateIcon()
        {
            string iconText = DateRangeControl.Precent.ToString();
            if (iconText.Length > 4) iconText = iconText.Substring(0, 4);
            PrecentIcon.Icon = IconGenerator.GetDefaultIcon(iconText);
        }

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

        private void openTestIconForm_Button_Click(object sender, EventArgs e)
        {
            new Forms.DebugForms.TextIconTestForm().Show(this);
        }
    }
}
