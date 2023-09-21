using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Die
    {
        // Create fields
        private int _roll;
        private Random _generator;

        // Create Constructor, Lets the variables acc work, and lets it store data.

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        // Accessor property, when defining property make it Uppercase Letter ex: Roll instead of roll or _roll

        public int Roll
        {
            get { return _roll; } // only get because they can only retrieve value and user cant change value. add "Set" to change.
        }

        // decides what is printed when toString is called
        // Public means can code can be used outside of class private means only in class

        public override string ToString()
        {
            return _roll + "";
        }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }

        public void DrawRoll()
        {
            switch (_roll)
            {
                case 1:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|   |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|   |");
                    Console.WriteLine(" ---");
                    break;
                case 2:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o  |");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|  o|");
                    Console.WriteLine(" ---");
                    break;
                case 3:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o  |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|  o|");
                    Console.WriteLine(" ---");
                    break;
                case 4:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|o o|");
                    Console.WriteLine(" ---");
                    break;
                case 5:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|o o|");
                    Console.WriteLine(" ---");
                    break;
                    break;
                case 6:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("|o o|");
                    Console.WriteLine(" ---");
                    break;
            }
        }
    }
}
