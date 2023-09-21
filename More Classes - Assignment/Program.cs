using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Raihan Carder

            string name;
            int selection = 0;
            double bank = 100, betAmount = 0;
            bool validSelection = false;
            Die die1 = new Die();
            Thread.Sleep(1000);
            Die die2 = new Die();
            die1.RollDie();
            die2.RollDie();
            Console.Title = "Gambling Game";

            Console.WriteLine("Casino");
            Console.WriteLine();
            Console.Write("Enter your Name:");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}, Today we're going to be rolling dies!");
            Console.WriteLine("What you can bet on includes: Doubles, Not Doubles, Even sum or Odd sum.") ;
            Console.WriteLine($"You starting amount is ${bank}!");
            Console.WriteLine("Type the number corresponding with your game!");
            Console.WriteLine("1. Doubles: Win double yout bet!");
            Console.WriteLine("2. Not Doubles: Win half your bet!");
            Console.WriteLine("3. Even Sum: Win your bet!");
            Console.WriteLine("4. Odd Sum: Win your bet!");
            Console.Write("What game would you like to play?");
            while (validSelection == false)
            {
                if (int.TryParse(Console.ReadLine(), out selection))
                {                   
                    if (selection == 1)
                    {
                        validSelection = true;
                    }
                    else if (selection == 2)
                    {
                        validSelection = true;
                    }
                    else if (selection == 3)
                    {
                        validSelection = true;
                    }
                    else if (selection == 4)
                    {
                        validSelection = true;
                    }
                    else
                    {
                        Console.Write("Error, what game would you like to play: ");
                    }
                }
                else
                {

                }
            }

            Console.Write("Enter your bet amount: ");
            if (Double.TryParse(Console.ReadLine(), out betAmount))
            {

            }
            else
            {

            }


            if (selection == 1)
            {
                Console.WriteLine("Welcome to the Doubles table, Your rolls are....");
                Thread.Sleep(1000);
                die1.DrawRoll();
                Thread.Sleep(1000);
                die2.DrawRoll();
                Console.WriteLine();
            }

            Console.ReadLine();
        }


    }
}
