using System;

namespace TaskProgresser.Core.Models
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


        public int TotalWeeks { get => (int)(Length.TotalDays / 7) + 1; }
        public int TotalDays { get => (int)Length.TotalDays; }



        private void VerifyDateTimePoint(DateTime point)
        {
            if (point < Start || End < point)
                throw new ArgumentOutOfRangeException($"The point ({point}) is not in range {ToString()}");
        }



        /// <summary>
        /// Определяет, находиться ли временная отметка внутри диапазона.
        /// </summary>
        /// <param name="point">Временная отметка DateTime (должна быть в диапазоне [Start, End])</param>
        /// <returns> Слева от диапазона = -1
        /// Внутри диапазона = 0
        /// Справа от диапазона = 1
        /// </returns>
        public int isInRange(DateTime point) {
            if (point < Start) return -1;
            if (point > End) return 1;
            return 0;
        }


        /// <summary>
        /// Принимает временную отметку, и возвращает долю, которую она составляет от текущего диапазона
        /// </summary>
        /// <param name="point">Временная отметка DateTime (должна быть в диапазоне [Start, End])</param>
        /// <returns>[0 ... 1]</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double GetFractionOf(DateTime point)
        {
            VerifyDateTimePoint(point);
            return (point - Start).TotalMilliseconds / Length.TotalMilliseconds;
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
