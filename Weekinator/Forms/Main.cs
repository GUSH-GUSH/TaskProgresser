using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using DateTimeToolKit.Models.DateRange;


namespace Weekinator
{
    public partial class Main : Form
    {
        
        public Main()
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


            
            dateRangeControl1.SetDateRange(new DateTime(2025, 02, 03), new DateTime(2025, 06, 23));
            dateRangeControl1.UpdateValue(DateTime.Now);
            
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += (obj, eventArgs) => {
                dateRangeControl1.UpdateValue(DateTime.Now);
            };
            timer.Start();
            
        }

        private void label_update() {
            //label1.Text = DateTime.Now.ToString();
        }
    }
}
