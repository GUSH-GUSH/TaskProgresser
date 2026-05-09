using System;

namespace DateTimeToolKit.Extensions.Truncate
{
    public static class DateTimeTruncateExtensions
    {
        public static DateTime TruncateToYear(this DateTime dt) => new DateTime(dt.Year, 1, 1, 0, 0, 0);
        public static DateTime TruncateToMonth(this DateTime dt) => new DateTime(dt.Year, dt.Month, 1, 0, 0, 0, 0);
        public static DateTime TruncateToDay(this DateTime dt) => new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
        public static DateTime TruncateToHour(this DateTime dt)
            => new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0, 0);
        public static DateTime TruncateToMinute(this DateTime dt)
            => new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0, 0);
        public static DateTime TruncateToSecond(this DateTime dt)
            => new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0);

        public static DateTime TruncateTo(this DateTime dt, TruncateLevel truncateLevel)
        {
            switch (truncateLevel)
            {
                case TruncateLevel.Year: return dt.TruncateToYear();
                case TruncateLevel.Month: return dt.TruncateToMonth();
                case TruncateLevel.Day: return dt.TruncateToDay();
                case TruncateLevel.Hour: return dt.TruncateToHour();
                case TruncateLevel.Minute: return dt.TruncateToMinute();
                case TruncateLevel.Second: return dt.TruncateToSecond();
                default: return dt;
            }
        }
    }
}
