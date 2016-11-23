using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess = 0;
            do
            {
                Console.WriteLine("Guess a Number");
                userGuess = Guess(userGuess);
                Console.WriteLine("You guessed " + userGuess);
            }
            while (userGuess != 0);
        }
        static int Guess(int userGuess)
        {
            userGuess = Convert.ToInt32(Console.ReadLine());
            return userGuess;
        }
    }
}
