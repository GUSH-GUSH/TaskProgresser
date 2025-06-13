using System;

namespace MyUtils
{
    public class DateRange
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public TimeSpan Length { get => End - Start; }


        public DateRange(DateTime start, DateTime end) => SetDateRange(start, end);
        public DateRange(DateTime start, TimeSpan length) => SetDateRange(start, length);


        public void SetDateRange(DateTime start, DateTime end)
        {
            if (start > end)
                throw new ArgumentException("The argument \"start\" can't be greater than \"end\"");

            Start = start;
            End = end;
        }
        public void SetDateRange(DateTime start, TimeSpan length)
        {
            Start = start;
            End = start + length;
        }


        public int TotalWeeks { get => (int)((End - Start).TotalDays / 7) + 1; }
        public int TotalDays { get => (int)(End - Start).TotalDays; }



        private void VerifyDateTimePoint(DateTime point)
        {
            if (point < Start || End < point)
                throw new ArgumentOutOfRangeException($"The point ({point}) is not in range {ToString()}");
        }


        /// <summary>
        /// Принимает временную отметку, и возвращает долю, которую она составляет от текущего диапазона
        /// </summary>
        /// <param name="point">Временная отметка DateTime (должна быть в диапазоне [Start, End]</param>
        /// <returns>[0 ... 1]</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double GetFractionOf(DateTime point)
        {
            VerifyDateTimePoint(point);
            return (point - Start).TotalMinutes / Length.TotalMinutes;
        }

        public int GetWeekOf(DateTime point)
        {
            VerifyDateTimePoint(point);
            return (int)((point - Start).TotalDays / 7) + 1;
        }

        public int GetDayOf(DateTime point)
        {
            VerifyDateTimePoint(point);
            return (int)(point - Start).TotalDays;
        }


        public override string ToString() => $"[{Start}, {End}]";
        public override bool Equals(object obj) => obj?.GetType() == GetType() && obj.ToString() == ToString();
        public override int GetHashCode() => ToString().GetHashCode();
    }
}
