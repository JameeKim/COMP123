/**
 * COMP123 Section 006 - Summer 2020
 * Lab 8 (Fri Jun 19, 2020): Astronaut
 * Dohyun Kim 301058465
 */

using System;
using System.Collections.Generic;

namespace COMP123.Lab08
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Astronaut> astronauts = new List<Astronaut>();
            AddAstronaut(astronauts, "Yuri Gagarin", "Russian");
            AddAstronaut(astronauts, "Alan Shepard", "American");
            AddAstronaut(astronauts, "Virgil Grissom", "American");
            AddAstronaut(astronauts, "Gherman Titov", "Russian");
            AddAstronaut(astronauts, "John Glenn", "American");
            AddAstronaut(astronauts, "Scott Carpenter", "American");

            Console.WriteLine("Only 5 astronauts created");
            int count = 1;
            foreach (Astronaut astronaut in astronauts)
            {
                Console.WriteLine($"{count++}. {astronaut}");
            }

            Astronaut.SetThreshold(6);
            AddAstronaut(astronauts, "Scott Carpenter", "American");
            Console.WriteLine("\nNow 6 astronauts created");
            count = 1;
            foreach (Astronaut astronaut in astronauts)
            {
                Console.WriteLine($"{count++}. {astronaut}");
            }
        }

        private static void AddAstronaut(List<Astronaut> list, string name, string nationality)
        {
            Astronaut astronaut = Astronaut.CreateAstronaut(name, nationality);
            if (astronaut != null)
                list.Add(astronaut);
        }
    }
}
