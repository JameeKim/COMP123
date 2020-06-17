/**
 * COMP123 Section 006 - Summer 2020
 * Assignment 2
 * Dohyun Kim 301058465
 * Pablo Saldarriaga 301092976
 * Ishan Gangji 300784236
 * Ethan St Louis STUDENT#
 */

using System;

namespace COMP123.Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tweets in the file\n");
            TweetManager.ShowAll();

            Console.WriteLine("\nTweets in the file with tag #im_rich\n");
            TweetManager.ShowAll("im_rich");

            Console.WriteLine("\nTweets initialized from code\n");
            TweetManager.Initialize();
            TweetManager.ShowAll();
        }
    }
}
