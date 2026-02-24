using DateTimeToolKit.Models.DateRange;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Weekinator.Controls;
using Weekinator.Forms;
using Weekinator.Services;
using WinFormsExtensions;

namespace Weekinator
{
    public partial class DateRangeControl : ClickableUserControl
    {
        #region --- data structs ---

        public enum DateRangeControlState
        {
            Unstarted,
            Finished,
            InProgress
        }

        #endregion


        #region --- static ---

        static Font WeekmarkIconFont = new Font("Arial Black", 24, FontStyle.Bold);

        public static DateRange DefaultDateRange => new DateRange(
                        DateTimePicker.MinimumDateTime,
                        DateTimePicker.MaximumDateTime
                    );
        public static DateTime MinValue => DateTimePicker.MinimumDateTime;
        public static DateTime MaxValue => DateTimePicker.MaximumDateTime;



        #endregion


        #region --- fields ---

        private DateTimePickersRangeController pickersController;
        private double fract; // Доля текущей даты в диапазоне от 0 до 1 (0 - начало, 1 - конец диапазона)
        private byte digits = 3; // Количество знаков после запятой для процентов
        private bool _enableIcon;
        private bool _enableEdit;

        private DateRangeControlState state = DateRangeControlState.Unstarted;



        #endregion


        #region --- properties ---

        public string RangeName { get; set; }

        public DateRange DateRange
        {
            get => pickersController.DateRange;
            set => SetDateRange(value);
        }

        public DateRangeControlState State
        {
            get => state;
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

        public byte Precision
        {
            get => digits;
            set { digits = value; UpdateVisual(); }
        }

        public bool EnableIcon {
            get => _enableIcon;
            set {
                _enableIcon = PrecentIcon.Visible = value;
            }
        }

        public bool EnableEdit {
            get => _enableEdit;
            set {
                _enableEdit = StartDateTimePicker.Enabled = EndDateTimePicker.Enabled = value;
            }
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


            PrecentIcon.Font = IconGenerator.DefaultFont;

            EnableIcon = false;
            EnableEdit = false;
        }

        public DateRangeControl(DateTime start, DateTime end) : this() => SetDateRange(start, end);

        public DateRangeControl(DateRange dateRange) : this() => SetDateRange(dateRange);

        private void DateRangeControl_Load(object sender, EventArgs e)
        {
            ProgressUpdaterService.AddDateRangeControl(this);
            this.Disposed += DateRangeControl_Disposed; ;
        }

        private void DateRangeControl_Disposed(object sender, EventArgs e)
        {
            ProgressUpdaterService.RemoveDateRangeControl(this);
            this.Disposed -= DateRangeControl_Disposed;
        }

        #endregion


        #region --- logic ---

        public void SetDateRange(DateRange dateRange) => pickersController.SetDateRange(dateRange);

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

            if (EnableIcon) UpdatePrecentIcon();
        }

        private void UpdatePrecentLabelLocation()
        {
            PrecentLabel.Location = new Point(
                x: (int)(MainProgressBar.Location.X - PrecentLabel.Size.Width / 2 + MainProgressBar.Size.Width * fract),
                y: PrecentLabel.Location.Y
            );
        }

        public void UpdatePrecentIcon()
        {
            double precent = Precent;
            PrecentIcon.HeaderText = $"{RangeName}: {precent}%\n\n";
            PrecentIcon.DisplayText = Math.Round(precent, 1).ToString();
        }

        #endregion


        #region--- Events Handlers ---

        private void DateRangeControl_Resize(object sender, EventArgs e) => UpdatePrecentLabelLocation();
        private void PrecentIcon_Click(object sender, EventArgs e) => IconClick?.Invoke();
        private void PrecentIcon_DoubleClick(object sender, EventArgs e) => IconDoubleClick?.Invoke();

        #endregion


        #region --- getters ---

        public double GetPrecent(int accuracy) => Math.Round(fract * 100, accuracy);

        #endregion


        #region --- events ---

        public event EventHandler OnValueChanged;
        public event Action IconClick;
        public event Action IconDoubleClick;

        #endregion

    }
}
