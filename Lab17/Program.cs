/**
 * COMP123 Section 006 - Summer 2020
 * Lab 17 (Fri Jun 26, 2020): Exception
 */

using System;

namespace COMP123.Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            PreventAppCrash(DivisionNoHandling);
            //DivisionNoHandling();
            //DivisionWithExceptionHandling();
        }

        delegate void SomeMethod();

        /// <summary>Catches the thrown error just for convenience</summary>
        static void PreventAppCrash(SomeMethod method)
        {
            try
            {
                method.Invoke();
                Console.WriteLine("ERROR: The method did not throw an exception");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception successfully thrown: {e}");
            }
        }

        /// <summary>Throws a "Division by Zero" exception</summary>
        static int Division(int top, int bottom) => top / bottom;

        static void DivisionNoHandling()
        {
            Division(1, 0);
        }

        static void DivisionWithExceptionHandling()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Divide by Zero Error: {e}");
            }
        }

        static void DivisionWithExceptionHandlingMoreInfo()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and print the associated message
            //your application should not crash
            try
            {
                Division(1, 0);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        static void DivisionWithExceptionHandlingThrow()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and print the associated message
            //You should create and throw a new exception
            //your application will crash
            try
            {
                Division(1, 0);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            throw new Exception("Greetings");


        }

        static void GeneratingException()
        {
            // new Exception("Hi");//You should create and throw a new exception
            throw new Exception("Hi");//your application will crash

        }

        /* Create a class that inherits from Exception class with the following specification:
        Should have the text “Exception” in its name
        Should inherits form Exception
        Should have a constructor that takes a single string argument.This constructor should invoke the base class constructor with the argument
        */

        public class MyException : Exception
        {
            public MyException(string message) : base(message)
            {
            }
        }

        static void GeneratingCustomException()//this one
        {
            //You should create and throw an object of your new exception class
            //your application will crash
            // throw it!! :D yay
            throw new MyException("My custom exception");
        }

        static void HandlingRandomException()
        {
            //You should call the method below and catch all the possible exceptions individually and display a sensible output
            //your application will not crash
            try
            {
                Console.WriteLine("Trying method below");
                GeneratingRandomException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 6;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new ArithmeticException();
                case 4:
                    throw new FormatException();
                case 5:
                    throw new InvalidCastException();
                case 6:
                    throw new OutOfMemoryException();
            }
        }
    }
}
