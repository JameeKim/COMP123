/**
 * COMP123 Section 006 - Summer 2020
 * Lab 6 (Fri Jun 12, 2020): Medal
 * Dohyun Kim 301058465
 */

using System.IO;
using System;
using System.Collections.Generic;

namespace COMP123.Lab06
{
    class Medal
    {
        public string Name { get; private set; }
        public string TheEvent { get; private set; }
        public string Color { get; private set; }
        public int Year { get; private set; }
        public bool IsRecord { get; private set; }

        public Medal(string name, string theEvent, string color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }

        public override string ToString()
        {
            string rec = IsRecord ? " (R)" : "";
            return $"{Year} - {TheEvent}{rec} - {Name} ({Color})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true);
            // print the object
            Console.WriteLine(m1);
            // print only the name of the medal holder
            Console.WriteLine(m1.Name);

            // create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", "Gold", 2012, false);
            // print the updated m2
            Console.WriteLine(m2);

            // create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };
            medals.Add(new Medal("Ryan Cochrane", "Swimming", "Silver", 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", "Silver", 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", "Gold", 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", "Bronze", 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", "Gold", 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", "Gold", 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", "Bronze", 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", "Bronze", 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", "Gold", 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", "Bronze", 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", "Bronze", 2012, false));

            // prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            for (int i = 0; i < medals.Count; i++)
            {
                Console.WriteLine($"{i + 1:d2}. {medals[i]}");
            }

            // prints a numbered list of 16 names
            Console.WriteLine("\n\nAll 16 names");
            for (int i = 0; i < medals.Count; i++)
            {
                Console.WriteLine($"{i + 1:d2}. {medals[i].Name}");
            }

            // prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            int idx = 0;
            foreach (Medal medal in medals)
            {
                if (medal.Color == "Gold")
                {
                    Console.WriteLine($"{++idx:d2}. {medal}");
                }
            }

            // prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals in 2012");
            idx = 0;
            foreach (Medal medal in medals)
            {
                if (medal.Year == 2012)
                {
                    Console.WriteLine($"{++idx:d2}. {medal}");
                }
            }

            // prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals");
            idx = 0;
            foreach (Medal medal in medals)
            {
                if (medal.Color == "Gold" && medal.Year == 2012)
                {
                    Console.WriteLine($"{++idx:d2}. {medal}");
                }
            }

            // prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            idx = 0;
            foreach (Medal medal in medals)
            {
                if (medal.IsRecord)
                {
                    Console.WriteLine($"{++idx:d2}. {medal}");
                }
            }

            // saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            TextWriter writer = new StreamWriter("./Medals.txt");
            foreach (Medal medal in medals)
            {
                writer.WriteLine(medal);
            }
            writer.Close();
        }
    }
}
