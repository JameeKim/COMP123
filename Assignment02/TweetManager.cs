/**
 * COMP123 Section 006 - Summer 2020
 * Assignment 2
 * Dohyun Kim 301058465
 * Pablo Saldarriaga 301092976
 * Ishan Gangji 300784236
 * Ethan St Louis 301070708
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace COMP123.Assignment02
{
    static class TweetManager
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME = "./Tweets.txt";

        static TweetManager()
        {
            TWEETS = new List<Tweet>();
            foreach (string line in File.ReadLines(FILENAME))
            {
                TWEETS.Add(Tweet.Parse(line));
            }
        }

        public static void Initialize()
        {
            TWEETS = new List<Tweet>() {
                new Tweet("Bob", "Bob", "Hello World", "HelloWorld"),
                new Tweet("Walter", "Jessie", "I'm hungry", "starving"),
                new Tweet("WallE", "Eve", "Eeeeeevaaaaaa", "ai_rules_the_world"),
                new Tweet("Iron Man", "Black Widow", "I've got Jarvis, but you ain't got nothing", "im_rich"),
                new Tweet("Wallace", "Wallace", "I have two kids", "centennial"),
            };
        }

        public static void ShowAll()
        {
            foreach (Tweet tweet in TWEETS)
            {
                Console.WriteLine(tweet);
            }
        }

        public static void ShowAll(string tag)
        {
            foreach (Tweet tweet in TWEETS)
            {
                if (tweet.Tag.ToLower() == tag.ToLower())
                {
                    Console.WriteLine(tweet);
                }
            }
        }

        public static void WriteToFile()
        {
            TextWriter file = new StreamWriter(FILENAME);
            foreach (Tweet tweet in TWEETS)
            {
                file.WriteLine($"{tweet.Id}\t{tweet.From}\t{tweet.To}\t{tweet.Body}\t{tweet.Tag}");
            }
            file.Close();
        }
    }
}
