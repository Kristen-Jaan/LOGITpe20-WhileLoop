using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 11);
                Console.WriteLine("What is my number?");
                int userGuess = Int32.Parse(Console.ReadLine());
                bool correctGuess = false;

                while (!correctGuess)
                {
                    if(randomNumber == userGuess)
                    {
                        Console.WriteLine("You Win");
                        correctGuess = true;
                    } else
                    {
                        Console.WriteLine("What is my number?");
                        userGuess = Int32.Parse(Console.ReadLine());
                    }
                    if(randomNumber > userGuess)
                    {
                        Console.WriteLine("My number is bigger.");
                        Console.WriteLine("What is my number?");
                        userGuess = Int32.Parse(Console.ReadLine());
                    }else
                    {
                        Console.WriteLine("My number is smaller.");
                        Console.WriteLine("What is my number?");
                        userGuess = Int32.Parse(Console.ReadLine());
                    }
                }
            }
        }
    }
}
