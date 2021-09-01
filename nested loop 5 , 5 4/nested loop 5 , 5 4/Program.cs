using System;

namespace nested_loop_5___5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 5; x >= 1; x--)
            {
                for (y = x; y <= 5; y++)
                {
                      Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

