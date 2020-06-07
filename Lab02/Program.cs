/**
 * COMP123 Section 006 - Summer 2020
 * Lab 2 (Fri Jun 5, 2020): Date
 * Dohyun Kim 301058465
 */

using System;

namespace COMP123.Lab02
{
    internal class Date
    {
        private int year;
        private int month;
        private int day;

        private static string MonthName(int month)
        {
            return month switch
            {
                1 => "Jan",
                2 => "Feb",
                3 => "Mar",
                4 => "Apr",
                5 => "May",
                6 => "Jun",
                7 => "Jul",
                8 => "Aug",
                9 => "Sep",
                10 => "Oct",
                11 => "Nov",
                12 => "Dec",
                _ => throw new ArgumentOutOfRangeException(
                     "month",
                     month,
                     "must be an integer from 1 to 12"),
            };
        }

        private static int MonthLength(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException(
                        "month",
                        month,
                        "must be an integer from 1 to 12");
            }
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        private static string DaySuffix(int day)
        {
            return day switch
            {
                int x when x < 1 || x > 31 => throw new ArgumentOutOfRangeException(
                    "day",
                    day,
                    "must be an integer from 1 to 31"),
                int x when x % 10 == 1 && x != 11 => "st",
                int x when x % 10 == 2 && x != 12 => "nd",
                int x when x % 10 == 3 && x != 13 => "rd",
                _ => "th",
            };
        }

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Date Clone()
        {
            return (Date)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{MonthName(month)} {day}{DaySuffix(day)}, {year}";
        }

        public void AddEnhanced(int days)
        {
            while (days > 0)
            {
                int tillNextMonth = MonthLength(month, year) - day + 1;

                if (tillNextMonth > days)
                {
                    day += days;
                    return;
                }

                days -= tillNextMonth;
                day = 1;
                month += 1;
                if (month > 12)
                {
                    year += 1;
                    month = 1;
                }
            }
        }

        public void Add(int days)
        {
            day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            month += months;
            day += days;
            Normalize();
        }

        public void Add(Date other)
        {
            year += other.year;
            month += other.month;
            day += other.day;
            Normalize();
        }

        private void Normalize()
        {
            while (day > 30)
            {
                day -= 30;
                month += 1;
            }

            while (month > 12)
            {
                month -= 12;
                year += 1;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Date date = new Date(2020, 6, 7);
            Console.WriteLine(date);

            AddDaysAndShow(date, 45, false);
            AddDaysAndShow(date, 180, false);

            Date date2 = date.Clone();
            int add2Months = 8;
            int add2Days = 25;
            date2.Add(add2Months, add2Days);
            Console.WriteLine($"{date2} (Added {add2Months} months and {add2Days} days)");

            Date date3 = date.Clone();
            int add3Years = 2;
            int add3Months = 3;
            int add3Days = 7;
            Date add3 = new Date(add3Years, add3Months, add3Days);
            date3.Add(add3);
            Console.WriteLine(
                $"{date3} (Added {add3Years} years, {add3Months} months, and {add3Days} days)");

            Console.WriteLine();
            Console.WriteLine("--- Enhanced version ---");
            Console.WriteLine(date);

            AddDaysAndShow(date, 15);
            AddDaysAndShow(date, 45);
            AddDaysAndShow(date, 180);
            AddDaysAndShow(date, 365);

            Date married = new Date(2018, 11, 5);
            Console.WriteLine($"I married my spouse on {married}.");
            int passed = 580;
            Console.WriteLine($"{passed} days have passed since then.");
            married.AddEnhanced(passed);
            Console.WriteLine($"It becomes {married} if I add the number of days.");
        }

        private static void AddDaysAndShow(Date original, int days, bool enhanced = true)
        {
            Date date = original.Clone();

            if (enhanced)
            {
                date.AddEnhanced(days);
            }
            else
            {
                date.Add(days);
            }

            Console.WriteLine($"{date} (Added {days} days)");
        }
    }
}
