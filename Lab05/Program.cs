/**
 * COMP123 Section 006 - Summer 2020
 * Lab 5 (Fri Jun 12, 2020): Pet
 * Dohyun Kim 301058465
 */

using System;
using System.Collections.Generic;

namespace COMP123.Lab05
{
    class Pet
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }
        public bool IsHouseTrained { get; private set; }

        public Pet(string name, int age, string description)
        {
            Name = name;
            Owner = "no one";
            Age = age;
            Description = description;
            IsHouseTrained = false;
        }

        public override string ToString()
        {
            string trained = IsHouseTrained ? "Trained" : "Untrained";
            return $"{Name}({Age}), {trained}, owned by {Owner}: {Description}";
        }

        public void Train()
        {
            IsHouseTrained = true;
        }

        public void SetOwner(string newOwner)
        {
            Owner = newOwner;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet> {
                new Pet("Tommy", 2, "A cute puppy"),
                new Pet("Kitty", 1, "A cat"),
                new Pet("Katty", 0, "Another cat"),
                new Pet("Cutey", 3, "Yet another cat, because cats are the answer"),
            };

            pets[0].SetOwner("Tom");
            pets[1].SetOwner("Cathy");
            pets[2].SetOwner("Cathy");

            pets[0].Train();
            pets[2].Train();

            Console.WriteLine("All pets:");
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"  - {pet}");
            }

            Console.WriteLine();

            Console.Write("Enter the name of the owner to see what pets they own: ");
            string owner = Console.ReadLine();
            Console.WriteLine($"These pets are owned by {owner}:");
            foreach (Pet pet in pets)
            {
                if (pet.Owner == owner)
                {
                    Console.WriteLine($"  - {pet}");
                }
            }
        }
    }
}
