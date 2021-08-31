using System;

namespace logical_opertater
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("The number entered is even number");
            }
            else
            {
                Console.WriteLine("The number entered is odd number");
            }
        }
    }
}
