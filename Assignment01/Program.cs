/**
 * COMP123 Section 006 - Summer 2020
 * Assignment #1
 * Dohyun Kim 301058465
 * Hiep Ngo 301121528
 */

using System;

namespace COMP123.Assignment01
{
    public class Rational
    {
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }

        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }

        public void IncreaseBy(Rational other)
        {
            int newDenom = Denominator * other.Denominator;
            int newNumer = (Numerator * other.Denominator) + (other.Numerator * Denominator);
            Denominator = newDenom;
            Numerator = newNumer;
        }

        public void DecreaseBy(Rational other)
        {
            int newDenom = Denominator * other.Denominator;
            int newNumer = (Numerator * other.Denominator) - (other.Numerator * Denominator);
            Denominator = newDenom;
            Numerator = newNumer;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Rational[] rationals = new Rational[] {
                new Rational(0),
                new Rational(1, 2),
                new Rational(2),
                new Rational(numerator: 0, denominator: 2),
            };

            Console.Write($"{rationals[1]} + {rationals[2]} = ");
            rationals[1].IncreaseBy(rationals[2]);
            Console.WriteLine(rationals[1]);

            Console.Write($"{rationals[0]} - {rationals[2]} = ");
            rationals[0].DecreaseBy(rationals[2]);
            Console.WriteLine(rationals[0]);
        }
    }
}
