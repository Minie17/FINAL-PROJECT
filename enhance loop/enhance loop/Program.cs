using System;

namespace enhance_loop
{
    class Program
    {
        public class ArrayForEachLoop
        {
            static void Main(String[] args)
            {
                String[] myArray;

                myArray = new String[10];
                myArray[0] = "aa";
                myArray[1] = "bb";
                myArray[2] = "cc";

                Console.WriteLine("Elements of the array: ");
                foreach (string val in myArray)         // Each element in myArray is a string
                {
                    Console.WriteLine(val);
                }

                Console.ReadLine();
            }
        }
    }
}

