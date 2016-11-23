using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        public static int RandNumber = 0;
        public static Random rand = new Random();

        static void Main(string[] args)
        {
            int userGuess = 0;
            RandNumber = rand.Next(1,10);
            do
            {
               
                Console.WriteLine("Guess a Number");
                userGuess = Guess(userGuess);
            }
            while (userGuess != RandNumber);
            Console.ReadKey();
        }
        static int Guess(int userGuess)
        {
            userGuess = Convert.ToInt32(Console.ReadLine());
            if (userGuess < RandNumber)
            {
                Console.WriteLine("You guessed too low.");
            }
            else if (userGuess > RandNumber)
            {
                Console.WriteLine("You guessed too high.");
            }
            else
            {
                Console.WriteLine("You guessed correct YAY :)");
            }
            return userGuess;
        }
    }
}
