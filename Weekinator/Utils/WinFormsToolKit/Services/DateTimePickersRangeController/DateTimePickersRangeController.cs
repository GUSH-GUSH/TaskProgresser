using System;
using System.Windows.Forms;
using DateTimeToolKit.Extensions.Truncate;
using DateTimeToolKit.Models.DateRange;

namespace WinFormsExtensions
{
    public class DateTimePickersRangeController : IDisposable
    {

        #region --- fields ---

        DateTimePicker startPicker;
        DateTimePicker endPicker;
        TruncateLevel truncateLevel = TruncateLevel.None;

        bool supperssionValueChanged = false;

        #endregion

        #region --- properties ---

        public DateTimePicker StartPicker
        {
            get => startPicker;
        }

        public DateTimePicker EndPicker
        {
            get => endPicker;
        }

        public TruncateLevel TruncateLevel
        {
            get => truncateLevel;
            set
            {
                truncateLevel = value;

                supperssionValueChanged = true;
                ResetPickersBounds();
                startPicker.Value = startPicker.Value.TruncateTo(truncateLevel);
                endPicker.Value = endPicker.Value.TruncateTo(truncateLevel);
                UpdateDateTimePickersBounds();
                OnValueChanged?.Invoke(this, EventArgs.Empty);

                supperssionValueChanged = false;
            }
        }

        public DateTime Start => startPicker.Value.TruncateTo(TruncateLevel);
        public DateTime End => endPicker.Value.TruncateTo(TruncateLevel);
        public DateRange DateRange => new DateRange(Start, End);

        #endregion

        #region --- events ---

        public event EventHandler OnValueChanged;

        public event EventHandler OnStartPickerLimitReached;

        public event EventHandler OnEndPickerLimitReached;

        public event EventHandler OnValueEquals;

        #endregion

        #region --- setup ---

        public DateTimePickersRangeController(DateTimePicker start, DateTimePicker end,
                                              DateRange initialize, TruncateLevel truncateLevel = TruncateLevel.None)
        {
            SetControls(start, end);
            SetDateRange(initialize);
            TruncateLevel = truncateLevel;
        }

        public void SetControls(DateTimePicker start, DateTimePicker end)
        {
            if (start == null || end == null)
                throw new ArgumentNullException("DateTimePickers cannot be null.");
            if (start == end)
                throw new ArgumentException("Start and end DateTimePickers cannot be the same instance.");

            Dispose();

            startPicker = start;
            endPicker = end;

            startPicker.ValueChanged += ValueChanged;
            end.ValueChanged += ValueChanged;
        }

        public void SetDateRange(DateRange range)
        {
            ResetPickersBounds();
            var start = range.Start.TruncateTo(TruncateLevel);
            var end = range.End.TruncateTo(TruncateLevel);

            startPicker.Value = start;
            endPicker.Value = end;
        }

        #endregion

        #region --- logic ---

        private void ValueChanged(object sender, EventArgs e)
        {
            if (supperssionValueChanged) return;

            supperssionValueChanged = true;
            startPicker.Value = startPicker.Value.TruncateTo(TruncateLevel);
            endPicker.Value = endPicker.Value.TruncateTo(TruncateLevel);
            supperssionValueChanged = false;

            UpdateDateTimePickersBounds();
            OnValueChanged?.Invoke(this, e);

            if (startPicker.Value == startPicker.MaxDate && sender == startPicker)
                OnStartPickerLimitReached?.Invoke(this, EventArgs.Empty);
            if (endPicker.Value == endPicker.MinDate && sender == endPicker)
                OnEndPickerLimitReached?.Invoke(this, EventArgs.Empty);
        }

        private void ResetPickersBounds()
        {
            startPicker.MinDate = endPicker.MinDate = DateTimePicker.MinimumDateTime;
            startPicker.MaxDate = endPicker.MaxDate = DateTimePicker.MaximumDateTime;
        }

        private void UpdateDateTimePickersBounds()
        {
            startPicker.MaxDate = endPicker.Value.TruncateTo(TruncateLevel);
            endPicker.MinDate = startPicker.Value.TruncateTo(TruncateLevel);
        }

        #endregion

        #region --- utilities ---

        public void Dispose()
        {
            if (startPicker != null) startPicker.ValueChanged -= ValueChanged;
            if (endPicker != null) endPicker.ValueChanged -= ValueChanged;
        }

        #endregion

    }
}
