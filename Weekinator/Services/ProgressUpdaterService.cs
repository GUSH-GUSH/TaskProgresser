using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TaskProgresser.Services
{
    internal static class ProgressUpdaterService
    {
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        static ProgressUpdaterService() {
            timer.Tick += (obj, eventArgs) => ExecuteOnce();
        }

        #region --- MANAGING TIMER ---

        public static void Start(int interval = 1000)
        {
            timer.Interval = interval;
            ExecuteOnce();
            timer.Start();
        }

        public static void Stop() => timer.Stop();

        #endregion

        #region --- MANAGING DATERANGECONTROLS ITEM ---

        public static void AddDateRangeControl(DateRangeControl rangeControl) => rangeControls.Add(rangeControl);

        public static void RemoveDateRangeControl(DateRangeControl rangeControl) => rangeControls.Remove(rangeControl);

        public static void ClearDateRangeControls() => rangeControls.Clear();

        #endregion

        #region --- LOGIC ---

        private static void UpdateProgress() {
            var now = DateTime.Now;

            Debug.WriteLine($"Количество подписок: {rangeControls.Count}");

            foreach (var control in rangeControls)
                control.UpdateValue(now);
        }

        public static void ExecuteOnce() {
            UpdateProgress();
            Tick?.Invoke();
        }

        #endregion

        static List<DateRangeControl> rangeControls = new List<DateRangeControl>();

        public static event Action Tick;
    }
}
