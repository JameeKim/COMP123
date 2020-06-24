/**
 * COMP123 Section 006 - Summer 2020
 * Lab 7 (Fri Jun 19, 2020): Time
 * Dohyun Kim 301058465
 */

namespace COMP123.Lab07
{
    internal enum TimeFormat
    {
        Mil,
        Hour12,
        Hour24,
    }

    internal class Time
    {
        private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;

        public int Hour { get; }
        public int Minute { get; }

        public Time(int hour = 0, int minute = 0)
        {
            Hour = hour > 0 && hour < 24 ? hour : 0;
            Minute = minute > 0 && minute < 60 ? minute : 0;
        }

        public override string ToString()
        {
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    return $"{Hour:d2}{Minute:d2}";
                case TimeFormat.Hour12:
                    int hour = Hour < 12 ? Hour : Hour - 12;
                    string amOrPm = Hour < 12 ? "AM" : "PM";
                    return $"{hour}:{Minute:d2} {amOrPm}";
                case TimeFormat.Hour24:
                    return $"{Hour:d2}:{Minute:d2}";
                default:
                    return $"Invalid format {TIME_FORMAT}; {Hour:d2}{Minute:d2}";
            }
        }

        public static void SetTimeFormat(TimeFormat timeFormat)
        {
            TIME_FORMAT = timeFormat;
        }
    }
}
