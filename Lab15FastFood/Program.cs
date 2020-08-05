using System;
using System.Collections.Generic;

namespace COMP123.Lab15FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Server> workers = new List<Server>
            {
                new Server("Jatin"),
                new Supervisor("Yash"),
                new Manager("Lovely"),
            };

            foreach (Server worker in workers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
