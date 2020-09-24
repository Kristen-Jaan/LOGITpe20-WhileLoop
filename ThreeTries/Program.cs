using System;

namespace ThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 11);
                int userInput;
                int counter = 0;

                

                while(counter < 3)
                {
                    Console.WriteLine("What is my number?");
                    userInput = Int32.Parse(Console.ReadLine());
                    if(randomNumber == userInput)
                    {
                        
                        Console.WriteLine("Congratulations, You won!");
                        break;
                    }else
                    {
                        Console.WriteLine("Try again!");
                         counter = counter + 1;
                        Console.WriteLine($"You have tried {counter} times.");
                        
                         
                       
                    }
                   
                    

                }
                
            }
                    
        }
    }
}
