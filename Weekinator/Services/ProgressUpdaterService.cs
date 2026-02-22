using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekinator.Services
{
    internal static class ProgressUpdaterService
    {
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        static ProgressUpdaterService() {
            timer.Tick += (obj, eventArgs) => UpdateProgress();
            timer.Tick += (obj, eventArgs) => Tick?.Invoke(obj, eventArgs);
        }

        #region --- MANAGING TIMER ---

        public static void Start(int interval = 1000)
        {
            timer.Interval = interval;
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

            foreach (var control in rangeControls)
                control.UpdateValue(now);
        }

        #endregion

        static List<DateRangeControl> rangeControls = new List<DateRangeControl>();

        public static event EventHandler Tick;
    }
}
