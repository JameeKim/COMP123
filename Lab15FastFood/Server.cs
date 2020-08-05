using System.Collections.Generic;

namespace COMP123.Lab15FastFood
{
    public class Server
    {
        /// <summary>
        /// A list of strings representing the duties of this server object
        /// </summary>
        protected List<string> duties;

        /// <summary>
        /// The wage of this server object
        /// </summary>
        protected double wages;

        /// <summary>
        /// Name of this object
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Constructor with name
        /// </summary>
        /// <param name="name">The name of the object</param>
        public Server(string name)
        {
            Name = name;
            wages = 15.0;
            duties = new List<string>
            {
                "reception",
                "serving",
                "cleaning",
                "survey",
            };
        }

        public override string ToString()
        {
            return $"{Name}: {string.Join(", ", duties)}";
        }
    }
}
