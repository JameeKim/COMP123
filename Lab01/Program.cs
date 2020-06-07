/**
 * COMP123 Section 006 - Summer 2020
 * Lab 1 (Fri May 29, 2020): Rectangle
 * Dohyun Kim 301058465
 */

using System;

namespace COMP123.Lab01
{
    public class BadRectangle
    {
        public int length;
        public int width;
    }

    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetArea()
        {
            return length * width;
        }

        public override string ToString()
        {
            return $"Rectangle {{ length: {length}, width: {width} }}";
        }
    }

    internal class Program
    {
        #region Part1Methods
        private static BadRectangle CreateBadRectangle(int length, int width)
        {
            BadRectangle rectangle = new BadRectangle();
            rectangle.length = length;
            rectangle.width = width;
            return rectangle;
        }

        private static void DescribeBadRectangle(BadRectangle rectangle)
        {
            Console.WriteLine(
                $"BadRectangle {{ length: {rectangle.length}, width: {rectangle.width} }}");
        }

        private static void CalculateAndDisplayArea(BadRectangle rectangle)
        {
            int area = rectangle.width * rectangle.length;
            Console.WriteLine($"The area of the bad rectangle is {area}.");
        }
        #endregion

        private static void Main(string[] args)
        {
            // Part 1
            BadRectangle smallRectangle = CreateBadRectangle(4, 5);
            DescribeBadRectangle(smallRectangle);
            CalculateAndDisplayArea(smallRectangle);

            // Part 2
            Rectangle[] rectangles = new Rectangle[] {
                new Rectangle(8, 5),
                new Rectangle(5, 3),
                new Rectangle(20, 10),
            };
            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"- Rectangle {i + 1}");
                Console.WriteLine(rectangles[i]);
                Console.WriteLine($"Area: {rectangles[i].GetArea()}");
            }
        }
    }
}
