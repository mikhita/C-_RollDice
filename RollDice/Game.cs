using System;
using System.Runtime.InteropServices;

namespace DiceRollGame
{
    class Game
    {
        private int randomNumber;
        public void Start()
        {
            Random random = new Random();
            randomNumber = random.Next(1,7);

            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter your guess (1-6): ");
                int guess = int.Parse(Console.ReadLine());

                if(guess == randomNumber)
                {
                    Console.WriteLine("You win");
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong number");
                }
                
            }

            Console.WriteLine("You lose");
            Console.ReadKey();
        }
    }
}