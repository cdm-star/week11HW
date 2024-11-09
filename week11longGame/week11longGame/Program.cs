using System;
using System.IO;

namespace week11longGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name");
            string userName = Console.ReadLine();

            int score = 0;
            string filePath = $"{userName}.txt";

            //check if a score file exists for user
            if (File.Exists(filePath))
            {
                //read score from file
                string savedScore = File.ReadAllText(filePath);
                if (int.TryParse(savedScore, out int loadedScore))
                {
                    score = loadedScore;
                    Console.WriteLine($"Welcome back,{userName}! Starting score: {score}");

                }
                else
                {

                    Console.WriteLine("Previous Score not found. Starting score of 0.");
                }


            }
            else {

                Console.WriteLine($"Welcome, {userName}! Starting score: {score}");
            }
            Console.WriteLine("Press any key tp increase score. Press enter to end the game.");

            while (true) { 
            
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;

                }
                else
                {
                    score++;
                    Console.WriteLine($"Score: {score}");
                }
            
            }

            File.WriteAllText(filePath, score.ToString());
            Console.WriteLine($"\n Game Over! Final score for {userName}: {score}");
            Console.WriteLine($"Score saved to {filePath}");

        }
    }
}
