using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    internal class Class1
    {
        static void Main()
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int tries = 0;

            while(true)
            {
                Console.Write("Enter a number between 1 and 100 (0 to quit): ");
                int guess = int.Parse(Console.ReadLine());

                if(guess == 0)
                {
                    break;
                }

                tries++;

                if(guess < number)
                {
                    Console.WriteLine("Low, try again.");
                } 
                else if (guess > number)
                {
                    Console.WriteLine("High, try again.");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The number was {number}!");
                    Console.WriteLine($"It took you {tries} tries.");
                    break;
                }
            }
        }
        
    }
}
