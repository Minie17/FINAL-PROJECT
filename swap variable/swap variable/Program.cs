using System;

namespace swap_variable
{
    class Program
    {
        static void SwapNum(ref int x, ref int y)
        {

            int tempswap = x;
            x = y;
            y = tempswap;

        }
        static void Main(string[] args)
        {
            int a = 45;
            int b = 60;

            Console.WriteLine("value of a and b before swappingn is");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after swapping is");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
        }
    }
}

