namespace DateTimeToolKit.Extensions.Truncate
{
    public enum TruncateLevel
    {
        Year,           // Truncate to year (January 1st, 00:00:00)
        Month,          // Truncate to month (first day of the month, 00:00:00)
        Day,            // Truncate to day (midnight of the day)
        Hour,           // Truncate to hour (start of the hour)
        Minute,         // Truncate to minute (start of the minute)
        Second,         // Truncate to second (start of the second)
        None            // No truncation, keep the original DateTime
    }
}
