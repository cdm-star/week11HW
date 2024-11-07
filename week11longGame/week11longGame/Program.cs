using System;
using System.Reflection.Metadata;

namespace week11longGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name");
            string userChoice=Console.ReadLine();

            int score = 0;

            while (true)
            {
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    score++;
                 
                }
                else if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                 
                    break;
                }
            }
        }
    }
}
