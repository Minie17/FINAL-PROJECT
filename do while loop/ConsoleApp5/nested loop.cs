using System;

namespace ConsoleApp5
{
    class Loop
    {
        //generate table of given number
        public void table(int num)
        {
            int i, t, j;
            for (i = num; i <= num + 5; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    for (i = num; i <= num + 3; i++)
                    {
                        t = i * j;
                        Console.WriteLine("{0} * {1} ={2}\t", i, j, t);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}


