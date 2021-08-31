using System;

namespace colour_scheme
{
    class Program
    {
        static void Main(string[] args)
        {
            string c1, c2;
            Console.WriteLine("Enter the first color");
            c1 = Console.ReadLine();
            Console.WriteLine("Enter the secound color");
            c2 = Console.ReadLine();
            if ((c1 == "RED" && c2 == "GREEN") || (c1 == "GREEN" && c2 == "RED"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Swith to yellow");
            }
            else if ((c1 == "RED" && c2 == "BLUE") || (c1 == "BlUE" && c2 == "RED"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("swith to Magenta");
            }
            else if ((c1 == "GREEN" && c2 == "BLUE") || (c1 == "BLUE" && c2 == "GREEN"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("swith to Cyan");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
                Console.ReadLine();
                
            }

        }
    }

