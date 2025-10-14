using System;
using System.Drawing;
using System.Windows.Forms;
using DateTimeToolKit.Models.DateRange;
using WinFormsExtensions;

namespace Weekinator
{
    public partial class DateRangeControl : UserControl
    {
        public enum DateRangeControlState
        {
            Unstarted,
            Finished,
            InProgress
        }


        #region --- fields ---

        private DateTimePickersRangeController pickersController;
        private double fract; // Доля текущей даты в диапазоне от 0 до 1 (0 - начало, 1 - конец диапазона)
        private byte digits = 3; // Количество знаков после запятой для процентов

        private DateRangeControlState state = DateRangeControlState.Unstarted;

        public static readonly DateRange DefaultDateRange = new DateRange(
                        DateTimePicker.MinimumDateTime,
                        DateTimePicker.MaximumDateTime
                    );

        #endregion


        #region --- properties ---

        public DateRange DateRange
        {
            get => pickersController.DateRange;
            set => SetDateRange(value);
        }

        public DateRangeControlState State
        {
            get { return state; }
            private set
            {
                state = value;
                switch (value)
                {
                    case DateRangeControlState.Unstarted:
                        Fract = 0;
                        //Enabled = false;
                        break;
                    case DateRangeControlState.Finished:
                        Fract = 1;
                        //Enabled = false;
                        break;
                    case DateRangeControlState.InProgress:
                        //Enabled = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }
            }
        }

        public double Precent
        {
            get => GetPrecent(digits);
        }

        private double Fract
        {
            get => fract;
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Fraction must be between 0 and 1.");
                fract = value;
                UpdateVisual();
            }
        }

        public byte Precision {
            get => digits;
            set { digits = value; UpdateVisual(); }
        }

        #endregion


        #region --- setup ---

        public DateRangeControl()
        {
            InitializeComponent();
            pickersController = new DateTimePickersRangeController(
                StartDateTimePicker,
                EndDateTimePicker,
                DefaultDateRange,
                DateTimeToolKit.Extensions.Truncate.TruncateLevel.Minute
            );
            pickersController.OnValueChanged += (o, a) => this.OnValueChanged?.Invoke(this, a);
        }

        public DateRangeControl(DateTime start, DateTime end) : this() => SetDateRange(start, end);

        public DateRangeControl(DateRange dateRange) : this() => SetDateRange(dateRange);

        private void DateRangeControl_Load(object sender, EventArgs e)
        {
     
        }

        #endregion


        #region --- logic ---

        public void SetDateRange(DateRange dateRange)
        {
            pickersController.SetDateRange(dateRange);
        }

        public void SetDateRange(DateTime start, DateTime end) => SetDateRange(new DateRange(start, end));

        public void UpdateValue(DateTime point)
        {
            switch (DateRange.isInRange(point))
            {
                case -1:
                    State = DateRangeControlState.Unstarted;
                    return;
                case 1:
                    State = DateRangeControlState.Finished;
                    return;
                case 0:
                    State = DateRangeControlState.InProgress;
                    Fract = DateRange.GetFractionOf(point);
                    return;
                default:
                    throw new ArgumentOutOfRangeException("point", point, null);
            }
        }

        #endregion


        #region --- visual ---

        private void UpdateVisual()
        {
            MainProgressBar.Value = (int)(Fract * MainProgressBar.Maximum);
            PrecentLabel.Text = $"{Precent}%";
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


        #region --- events ---

        public event EventHandler OnValueChanged;

        #endregion


        #region --- getters ---

        public double GetPrecent(int accuracy) => Math.Round(fract * 100, accuracy);

        #endregion
    }
}
