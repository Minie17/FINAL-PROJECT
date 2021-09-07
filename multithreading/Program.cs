using System;
using System.Threading;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo1();
            PrintInfo2();
            Console.ReadLine();
        }
        static void PrintInfo1()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First method completed");
        }
        static void PrintInfo2()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Second method completed");
        }
    }
}
