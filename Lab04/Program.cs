/**
 * COMP123 Section 006 - Summer 2020
 * Lab 4 (Fri Jun 12, 2020): List
 * Dohyun Kim 301058465
 */

using System;
using System.Collections.Generic;

namespace COMP123.Lab04
{
    class Rectangle
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declaration and initialization
            List<int> numbers = new List<int>();
            List<double> radii = new List<double>() { 1.0, 2.1, 3.6 };
            List<string> pms = new List<string>() { "Trudeau", "Harper", "Martin", "Chretien", "Campbell" };
            List<Rectangle> rectangles = new List<Rectangle>();

            // Adding an item
            numbers.Add(3);
            pms.Add("Mulroney");

            // Inserting an item
            pms.Insert(2, "William Lyon Mackenzie King");

            // Removing an item
            pms.Remove("Mulroney");
            radii.RemoveAt(1);

            // Removing all items
            numbers.Clear();

            // Checking an item
            Console.WriteLine($"Does the list contain Narendra Pershad: {pms.Contains("Narendra Pershad")}");
            Console.WriteLine($"Does the list contain Trudeau: {pms.Contains("Trudeau")}");

            // The number of items
            Console.WriteLine($"The list of numbers has {numbers.Count} elements");

            // Add items before the list
            numbers.AddRange(new int[] { 3, 2, 1, 8, 16, 9, 10, 7 });

            // Traversing
            Console.WriteLine();
            Console.WriteLine("Display all items using a for loop");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Display all items using a foreach loop");
            foreach (int x in numbers)
            {
                Console.Write($"{x}, ");
            }
            Console.WriteLine();

            // Traversing with filtering
            Console.WriteLine();
            Console.WriteLine("Names that are longer than 6 letter");
            foreach (string pm in pms)
            {
                if (pm.Length > 6)
                {
                    Console.Write($"{pm}, ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Names starting with C");
            foreach (string pm in pms)
            {
                if (pm.StartsWith("C"))
                {
                    Console.Write($"{pm}, ");
                }
            }
        }
    }
}
