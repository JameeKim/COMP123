/**
 * COMP123 Section 006 - Summer 2020
 * Lab 7 (Fri Jun 19, 2020): Time
 * Dohyun Kim 301058465
 */

using System;
using System.Collections.Generic;

namespace COMP123.Lab07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Time a = new Time(9, 35);
            Console.WriteLine(a);

            Time b = new Time(18, 5);
            Console.WriteLine(b);

            Time c = new Time(28, 500);
            Console.WriteLine(c);

            Time d = new Time(10);
            Console.WriteLine(d);

            List<Time> times = new List<Time>() { a, b, c, d };

            PrintTimes(times, TimeFormat.Hour12, "Normal");
            PrintTimes(times, TimeFormat.Mil, "Military");
            PrintTimes(times, TimeFormat.Hour24, "24 hour");
        }

        private static void PrintTimes(List<Time> times, TimeFormat format, string formatName)
        {
            Console.WriteLine($"\n\n{formatName} time format");
            Time.SetTimeFormat(format);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
        }
    }
}
