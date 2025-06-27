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
        private DateRange dateRange;
        private double fract;
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
            dateRangeControl1.GetFractionOf(DateTime.Now);
            
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (obj, eventArgs) => {
                dateRangeControl1.GetFractionOf(DateTime.Now);
            };
            timer.Start();
            
        }

        private void SetDateRange(DateTime start, DateTime end)
        {
            dateRange = new DateRange(start, end);
            StartDate.MinDate = DateTimePicker.MinimumDateTime;
            StartDate.MaxDate = DateTime.Now;
            StartDate.Value = start;

            EndDate.MinDate = DateTime.Now.AddDays(1);
            EndDate.MaxDate = DateTimePicker.MaximumDateTime; 
            EndDate.Value = end;
        }
        private void UpdatePrecentLabelText(byte digits = 5)
        {
            PrecentLabel.Text = $"{Math.Round(fract * 100, digits)}%";
        }
        private void UpdatePrecentLabelLocation()
        {
            PrecentLabel.Location = new Point(
                (int)(MainProgressBar.Location.X - PrecentLabel.Size.Width / 2 + MainProgressBar.Size.Width * fract),
                PrecentLabel.Location.Y);
        }
        private void UpdateMainProgressBarValue()
        {
            MainProgressBar.Value = (int)(fract * MainProgressBar.Maximum);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            UpdatePrecentLabelLocation();
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            SetDateRange(StartDate.Value, dateRange.End);
            fract = dateRange.GetFractionOf(DateTime.Now); //Очень условно пока-что
            UpdatePrecentLabelText();
            UpdatePrecentLabelLocation();
            UpdateMainProgressBarValue();
        }

        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            //if(StartDate.Value > ...) Проверка, что выбранная дата не уходит за диапазон
            //Эта проверка уже не нужна, т.к. все проерки сделаны путём ограничения выбора даты
            SetDateRange(dateRange.Start, EndDate.Value);
            fract = dateRange.GetFractionOf(DateTime.Now); //Очень условно пока-что
            UpdatePrecentLabelText();
            UpdatePrecentLabelLocation();
            UpdateMainProgressBarValue();
        }

        private void Update()
        {
            DateTime point = DateTime.Now;
            fract = dateRange.GetFractionOf(point);

            UpdatePrecentLabelText();
            UpdatePrecentLabelLocation();
            UpdateMainProgressBarValue();
        }

        private void label_update() {
            //label1.Text = DateTime.Now.ToString();
        }
    }
}
