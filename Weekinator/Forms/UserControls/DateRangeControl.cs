using System;
using System.Drawing;
using System.Windows.Forms;
using DateTimeToolKit.Models.DateRange;
using WinFormsExtensions;

namespace Weekinator
{
    public partial class DateRangeControl : UserControl
    {

        #region --- fields ---

        private DateTimePickersRangeController pickersController;
        //private DateRange dateRange; // Диапазон дат
        private double fract; // Доля текущей даты в диапазоне от 0 до 1 (0% - начало, 1 - конец диапазона)
        private byte digits = 3; // Количество знаков после запятой для процентов

        #endregion

        #region --- properties ---

        public DateRange DateRange
        {
            get => pickersController.DateRange;
            set => SetDateRange(value);
        }

        #endregion

        #region --- setup ---

        public DateRangeControl()
        {
            InitializeComponent();
            pickersController = new DateTimePickersRangeController(
                StartDateTimePicker,
                EndDateTimePicker,
                new DateRange(
                    DateTimePicker.MinimumDateTime,
                    DateTimePicker.MaximumDateTime
                ),
                DateTimeToolKit.Extensions.Truncate.TruncateLevel.Minute
            );
        }

        public DateRangeControl(DateTime start, DateTime end) : this() => SetDateRange(start, end);

        public DateRangeControl(DateRange dateRange) : this() => SetDateRange(dateRange);

        #endregion

        #region --- logic ---

        public void SetDateRange(DateRange dateRange)
        {
            //this.dateRange = dateRange;
            pickersController.SetDateRange(dateRange);
        }

        public void SetDateRange(DateTime start, DateTime end) => SetDateRange(new DateRange(start, end));

        public double GetFractionOf(DateTime point)
        {
            try { fract = DateRange.GetFractionOf(point); }
            catch (ArgumentOutOfRangeException ex) {}
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
