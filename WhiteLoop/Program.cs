using System;
using System.Diagnostics.CodeAnalysis;

namespace WhiteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            {
                Random rnd = new Random();

                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Your random number is {myRandomNumber}");
                Console.WriteLine("What is my number from 1 to 10");
                int UserGuess = Int32.Parse(Console.ReadLine());

                if(myRandomNumber == UserGuess)
                {
                    Console.WriteLine("Congraluations! You've played me!");
                }else
                {
                    Console.WriteLine($"Wrong. My Random Number is {myRandomNumber}");
                }

            }
        }
    }
}
