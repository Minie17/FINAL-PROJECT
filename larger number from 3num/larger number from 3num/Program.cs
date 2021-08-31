using System;

namespace larger_number_from_3num
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, large;
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                large = a;
            }
            else if (b > a && b > c)
            {
                large = b;
            }
            else
            {
                large = c;
            }
            Console.WriteLine("Largest number is {0}", large);
            large = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
            Console.WriteLine("Largest number is {0}", large);
            Console.ReadLine();
        }
    }
}
