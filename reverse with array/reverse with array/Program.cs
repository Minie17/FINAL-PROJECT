using System;

namespace reverse_with_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 56,78,89,23,87,76 };
            int[] temp = list;
            Console.Write("Original Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
