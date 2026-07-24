using System;
using System.Drawing;
using System.Windows.Forms;
using TaskProgresser.Core.Models;
using TaskProgresser.WinForms.Helpers;
using TaskProgresser.WinForms.UIControllers;

using WinFormsExtensions;

namespace TaskProgresser.WinForms.Components.Controls
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
        private double fract;
        private byte digits = 3;
        private bool _enableIcon;
        private bool _enableEdit;
        private bool _autoUpdate;

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
                        break;
                    case DateRangeControlState.Finished:
                        Fract = 1;
                        break;
                    case DateRangeControlState.InProgress:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }
            }
        }

        public double Precent => GetPrecent(digits);

        private double Fract
        {
            get => fract;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Fraction must be more than 0");
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
            set => _enableIcon = TextPrecentIcon.Visible = value;
        }

        public bool EnableEdit {
            get => _enableEdit;
            set => _enableEdit = DTP_Start.Enabled = DTP_End.Enabled = value;
        }

        public bool AutoUpdate
        {
            get => _autoUpdate;
            set
            {
                if(value == _autoUpdate) return;
                _autoUpdate = value;
                if (value) ProgressUpdateController.AddDateRangeControl(this);
                else ProgressUpdateController.RemoveDateRangeControl(this);
            }
        }

        #endregion


        #region --- setup ---

        public DateRangeControl()
        {
            InitializeComponent();
            pickersController = new DateTimePickersRangeController(
                DTP_Start,
                DTP_End,
                DefaultDateRange,
                TaskProgresser.Core.Extensions.Truncate.TruncateLevel.Minute
            );
            pickersController.OnValueChanged += (o, a) => this.OnValueChanged?.Invoke(this, a);

            TextPrecentIcon.Font = IconFactory.DefaultFont;

            EnableIcon = false;
            EnableEdit = false;
        }

        public DateRangeControl(DateTime start, DateTime end) : this() => SetDateRange(start, end);

        public DateRangeControl(DateRange dateRange) : this() => SetDateRange(dateRange);

        private void DateRangeControl_Load(object sender, EventArgs e)
        {
            AutoUpdate = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                AutoUpdate = false;
                pickersController?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
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
                    Fract = DateRange.GetFractionOf(point);
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
            MainProgressBar.Value = Math.Min(
                (int)(Fract * MainProgressBar.Maximum),
                MainProgressBar.Maximum
            );
            LBL_Precent.Text = $"{Precent}%";

            if ( Fract > 1 ) LBL_Precent.ForeColor = Color.Red;
            else LBL_Precent.ForeColor = Color.Black;

            UpdatePrecentLabelLocation();

            if (EnableIcon) UpdatePrecentIcon();
        }

        private void UpdatePrecentLabelLocation()
        {
            LBL_Precent.Location = new Point(
                x: (int)(MainProgressBar.Location.X - LBL_Precent.Size.Width / 2 + MainProgressBar.Size.Width * Math.Min(fract, 1.0)),
                y: LBL_Precent.Location.Y
            );
        }

        public void UpdatePrecentIcon()
        {
            double precent = Precent;
            TextPrecentIcon.HeaderText = $"{RangeName}: {precent}%\n\n";
            TextPrecentIcon.DisplayText = Math.Round(precent, 1).ToString();
        }

        #endregion


        #region--- Events Handlers ---

        private void DateRangeControl_Resize(object sender, EventArgs e) => UpdatePrecentLabelLocation();
        private void PrecentIcon_Click(object sender, EventArgs e) => OnIconClick?.Invoke();
        private void PrecentIcon_DoubleClick(object sender, EventArgs e) => OnIconDoubleClick?.Invoke();
        private void PrecentIconMenuItem_HideIcon_Click(object sender, EventArgs e) => OnHideIcon?.Invoke();
        private void PrecentIconMenuItem_ShowFlyoutForm_Click(object sender, EventArgs e) => OnIconClick?.Invoke();
        
        #endregion


        #region --- getters ---

        public double GetPrecent(int accuracy) => Math.Round(fract * 100, accuracy);

        #endregion


        #region --- events ---

        public event EventHandler OnValueChanged;
        public event Action OnIconClick;
        public event Action OnIconDoubleClick;
        public event Action OnHideIcon;

        #endregion

    }
}
