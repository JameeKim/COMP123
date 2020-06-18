/**
 * COMP123 Section 006 - Summer 2020
 * Assignment 2
 * Dohyun Kim 301058465
 * Pablo Saldarriaga 301092976
 * Ishan Gangji 300784236
 * Ethan St Louis 301070708
 */

namespace COMP123.Assignment02
{
    class Tweet
    {
        private static int CURRENT_ID;
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }


        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = CURRENT_ID.ToString();

            CURRENT_ID += 1;
        }

        public Tweet(string from, string to, string body, string tag, string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = id;
        }

        public override string ToString()
        {
            string body = Body.Length > 40 ? Body.Substring(0, 40) : Body;
            return $"FROM {From} TO {To}\n{body}\n#{Tag}\n";
        }

        public static Tweet Parse(string line)
        {
            string[] w = line.Split(new char[] { '\t' });
            return new Tweet(w[1], w[2], w[3], w[4], w[0]);
        }
    }
}
