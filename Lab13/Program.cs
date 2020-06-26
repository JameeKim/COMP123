/**
 * COMP123 Section 006 - Summer 2020
 * Lab 13 (Fri Jun 26, 2020): Course
 */

using System.IO;
using System;
using System.Collections.Generic;

namespace COMP123.Lab13
{
    public enum DisplayOption
    {
        All,
        Code,
        Name,
        Prerequisite,
        Semester,
    }

    class Course
    {
        public string Code { get; }
        public string Description { get; }
        public string Name { get; }
        public string Prerequisites { get; }
        public int Semester { get; }

        public Course(string code, string name, string description, string semester, string prerequisites)
        {
            Code = code;
            Name = name;
            Description = description;
            Semester = Convert.ToInt32(semester);
            Prerequisites = prerequisites;
        }

        public override string ToString()
        {
            string description = Description.Length > 60 ? Description.Substring(0, 60) : Description;
            return $"{Code}, {Name}, {Semester}, {Prerequisites}, {description}";
        }
    }

    class CourseManager
    {
        private static List<Course> courses;

        public static void Display(DisplayOption option, string toMatch = "")
        {

            switch (option)
            {
                case DisplayOption.All:
                    foreach (Course course in courses)
                    {
                        Console.WriteLine(course);
                    }
                    break;

                case DisplayOption.Code:
                    foreach (Course course in courses)
                    {
                        if (toMatch == "" || course.Code == toMatch)
                        {
                            Console.WriteLine(course);
                        }
                    }
                    break;

                case DisplayOption.Name:
                    foreach (Course course in courses)
                    {
                        if (toMatch == "" || course.Name == toMatch)
                        {
                            Console.WriteLine(course);
                        }
                    }
                    break;

                case DisplayOption.Prerequisite:
                    foreach (Course course in courses)
                    {
                        if (toMatch == "" || course.Prerequisites.Contains(toMatch))
                        {
                            Console.WriteLine(course);
                        }
                    }
                    break;

                case DisplayOption.Semester:
                    foreach (Course course in courses)
                    {
                        if (toMatch == "" || course.Semester.ToString() == toMatch)
                        {
                            Console.WriteLine(course);
                        }
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException("option", option, "not a valid value for DisplayOption");
            }
        }

        public static void WriteCourses(string filename)
        {
            courses = new List<Course>() {
                new Course("COMP123", "Programming 2", "Level up your C# skills to a new level", "3", "COMP100"),
                new Course("COMP100", "Programming 1", "Introduction to C#", "2", "")
            };

            TextWriter writer = new StreamWriter(filename);
            foreach (Course course in courses)
            {
                writer.WriteLine($"{course.Code};{course.Name};{course.Semester};{course.Prerequisites};{course.Description}");
            }
            writer.Close();
        }

        public static void LoadCourses(string filename)
        {
            courses = new List<Course>();

            TextReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(';');
                courses.Add(new Course(data[0], data[1], data[4], data[2], data[3]));
                line = reader.ReadLine();
            }
            reader.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = "./Courses.txt";
            try
            {
                CourseManager.LoadCourses(filename);

                Console.WriteLine("\nAll courses");
                CourseManager.Display(DisplayOption.All);

                string toSearch = "COMP100";
                Console.WriteLine("\nWith prerequsite " + toSearch);
                CourseManager.Display(DisplayOption.Prerequisite, toSearch);

                Console.WriteLine("\nWith title " + toSearch);
                CourseManager.Display(DisplayOption.Code, toSearch);

                toSearch = "Programing 1";
                Console.WriteLine("\nWith name " + toSearch);
                CourseManager.Display(DisplayOption.Name, toSearch);

                toSearch = "2";
                Console.WriteLine("\nIn semester " + toSearch);
                CourseManager.Display(DisplayOption.Semester, toSearch);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Given file not found; creating one...");
                CourseManager.WriteCourses(filename);
                Console.WriteLine($"File written to {filename}. Run the command again.");
            }
        }
    }
}
