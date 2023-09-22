using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
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

            Console.Title = "Gambling Game";
            Console.Write("Enter your Name: ");
            name = Console.ReadLine().Trim();
            Console.Clear();

            while (bank > 0)
            {
                die1.RollDie();
                die2.RollDie();

                Console.WriteLine("Casino");
                Console.WriteLine();            
                Console.WriteLine($"Welcome {name}, Today we're going to be rolling dies!");
                Console.WriteLine("What you can bet on includes: Doubles, Not Doubles, Even sum or Odd sum.");
                Console.WriteLine($"You have ${bank}!");
                Console.WriteLine("Type the number corresponding with your game!");
                Console.WriteLine("1. Doubles: Win double yout bet!");
                Console.WriteLine("2. Not Doubles: Win half your bet!");
                Console.WriteLine("3. Even Sum: Win your bet!");
                Console.WriteLine("4. Odd Sum: Win your bet!");
                Console.Write("What game would you like to play? ");
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
                        Console.Write("Error, what game would you like to play: ");
                    }
                }
                validSelection = false;

                Console.Write("Enter your bet amount: ");

                    if (Double.TryParse(Console.ReadLine(), out betAmount))
                    {
                       
                        if (betAmount > bank)
                        {
                            betAmount = bank;
                            Console.WriteLine($"You don't have enough for that bet, you're ALL IN");
                        }
                        else if (betAmount < 0)
                        {
                            betAmount = 0.00;
                        }
                    }
                    else
                    {
                        betAmount = 0.00;
                    }
                    Console.WriteLine($"You've bet: ${betAmount}.");
                    

                Console.WriteLine();

                if (selection == 1)
                {
                    Console.WriteLine("Welcome to the Doubles table, Your rolls are....");
                    Thread.Sleep(1000);
                    die1.DrawRoll();
                    Thread.Sleep(1000);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if (die1.Roll == die2.Roll)
                    {
                        bank += betAmount*2;

                        Console.WriteLine($"WINNER WINNER Chicken dinner, you now have ${bank}.");
                    }
                    else
                    {
                        bank -= betAmount;
                        Console.WriteLine($"Wah wah, Massive Loser! You now have ${bank}.");
                    }
                }
                else if (selection == 2)
                {
                    Console.WriteLine("Welcome to the Not Doubles table, Your rolls are....");
                    Thread.Sleep(1000);
                    die1.DrawRoll();
                    Thread.Sleep(1000);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if (die1.Roll != die2.Roll)
                    {
                        bank += betAmount * 0.5;

                        Console.WriteLine($"WINNER WINNER Chicken dinner, you now have ${bank}.");
                    }
                    else
                    {
                        bank -= betAmount;
                        Console.WriteLine($"Wah wah, Unlucky Loser! You now have ${bank}.");
                    }
                }
                else if (selection == 3)
                {
                    Console.WriteLine("Welcome to the Even Sum table, Your rolls are....");
                    Thread.Sleep(1000);
                    die1.DrawRoll();
                    Thread.Sleep(1000);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if ((die1.Roll + die2.Roll)%2==0)
                    {
                        bank += betAmount;

                        Console.WriteLine($"WINNER WINNER Chicken dinner, you now have ${bank}.");
                    }
                    else
                    {
                        bank -= betAmount;
                        Console.WriteLine($"Wah wah, Crybaby Loser! You now have ${bank}.");
                    }
                }
                else if (selection == 4)
                {
                    Console.WriteLine("Welcome to the Odd Sum table, Your rolls are....");
                    Thread.Sleep(1000);
                    die1.DrawRoll();
                    Thread.Sleep(1000);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if ((die1.Roll + die2.Roll) % 2 != 0)
                    {
                        bank += betAmount;

                        Console.WriteLine($"WINNER WINNER Chicken dinner, you now have ${bank}.");
                    }
                    else
                    {
                        bank -= betAmount;
                        Console.WriteLine($"Wah wah, Lame Loser! You now have ${bank}.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
                    

                Console.ReadLine();
                Console.Clear();
            }
            
            Console.WriteLine("You're Broke! You're escorted out of the Casino.");
            Console.WriteLine("Have a great day.");
            Console.ReadLine();
        }


    }
}
