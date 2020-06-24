/**
 * COMP123 Section 006 - Summer 2020
 * Lab 8 (Fri Jun 19, 2020): Astronaut
 * Dohyun Kim 301058465
 */

namespace COMP123.Lab08
{
    internal class Astronaut
    {
        private static int ASTRONAUT_COUNT; // 0 by default
        private static int THRESHOLD = 5;

        public string Name { get; }
        public string Nationality { get; }

        private Astronaut(string name, string nationality)
        {
            Name = name;
            Nationality = nationality;
            ASTRONAUT_COUNT++;
        }

        public override string ToString()
        {
            return $"[{Nationality}] {Name}";
        }

        public static Astronaut CreateAstronaut(string name, string nationality)
        {
            return ASTRONAUT_COUNT < THRESHOLD ? new Astronaut(name, nationality) : null;
        }

        public static void SetThreshold(int threshold)
        {
            THRESHOLD = threshold;
        }
    }
}
