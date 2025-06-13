using MyUtils;
using System;
using System.Drawing;

using System.Windows.Forms;

namespace Weekinator
{
    public partial class DateRangeControl : UserControl
    {
       
        #region --- fields ---
        
        private DateRange dateRange; // Диапазон дат, который контролируется
        private double fract; // Доля текущей даты в диапазоне от 0 до 1 (0% - начало, 1 - конец диапазона)
        private byte digits = 3; // Количество знаков после запятой для процентов

        #endregion

        #region --- setup ---

        public DateRangeControl()
        {
            InitializeComponent();
        }

        public DateRangeControl(DateTime start, DateTime end) : this() => SetDateRange(start, end);
        
        public DateRangeControl(DateRange dateRange) : this() => SetDateRange(dateRange);

        #endregion

        #region --- buisness logic ---

        public void SetDateRange(DateRange dateRange)
        {
            this.dateRange = dateRange;
            StartDateTimePicker.MinDate = DateTimePicker.MinimumDateTime;
            StartDateTimePicker.Value = DateTimePicker.MinimumDateTime;
            StartDateTimePicker.MaxDate = DateTime.Now;
            StartDateTimePicker.Value = dateRange.Start;

            EndDateTimePicker.MinDate = DateTime.Now.AddDays(1);
            EndDateTimePicker.Value = DateTime.Now.AddDays(1);
            EndDateTimePicker.MaxDate = DateTimePicker.MaximumDateTime;
            EndDateTimePicker.Value = dateRange.End;
        }

        public void SetDateRange(DateTime start, DateTime end) => SetDateRange(new DateRange(start, end));

        public double GetFractionOf(DateTime point)
        {
            fract = dateRange.GetFractionOf(point);
            UpdateMainProgressBar();
            return fract;
        }

        #endregion

        #region --- visual ---

        private void UpdateMainProgressBar()
        {
            MainProgressBar.Value = (int)(fract * MainProgressBar.Maximum);
            PrecentLabel.Text = $"{Math.Round(fract * 100, digits)}%";
            UpdatePrecentLabelLocation();
        }

        private void UpdatePrecentLabelLocation()
        {
            PrecentLabel.Location = new Point(
                x: (int)(MainProgressBar.Location.X - PrecentLabel.Size.Width / 2 + MainProgressBar.Size.Width * fract),
                y: PrecentLabel.Location.Y
            );
        }

        private void DateRangeControl_Resize(object sender, EventArgs e) => UpdatePrecentLabelLocation();

        #endregion

    }
}
