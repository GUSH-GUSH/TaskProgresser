using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TaskProgresser.WinForms.Services
{
    internal static class ProgressUpdaterService
    {

        #region --- FIELDS ---
        
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private static List<DateRangeControl> rangeControls = new List<DateRangeControl>();

        #endregion --- FIELDS ---

        #region --- SETUP ---

        static ProgressUpdaterService()
        {
            timer.Tick += (obj, eventArgs) => ExecuteOnce();
        }

        #endregion --- SETUP ---

        #region --- MANAGING TIMER ---

        public static void Start(int interval = 1000)
        {
            ExecuteOnce();
            timer.Interval = interval;
            timer.Start();
        }

        public static void Stop() => timer.Stop();

        #endregion --- MANAGING TIMER ---

        #region --- MANAGING DATERANGECONTROLS ITEM ---

        public static void AddDateRangeControl(DateRangeControl rangeControl) => rangeControls.Add(rangeControl);

        public static void RemoveDateRangeControl(DateRangeControl rangeControl) => rangeControls.Remove(rangeControl);

        public static void ClearDateRangeControls() => rangeControls.Clear();

        #endregion --- MANAGING DATERANGECONTROLS ITEM ---

        #region --- UPDATE LOGIC ---

        private static void UpdateProgress()
        {
            //Debug.WriteLine($"Количество подписок: {rangeControls.Count}");
            foreach (var control in rangeControls) control.UpdateValue(DateTime.Now);
        }

        public static void ExecuteOnce()
        {
            UpdateProgress();
            Tick?.Invoke();
        }

        #endregion

        public static event Action Tick;
    }
}
