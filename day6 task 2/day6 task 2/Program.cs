using System;

namespace day6_task_2
{
    class ArrayExample
    {
        public static void Main(string[] args)
        {
            String[] str = new String[]
            {
                "sunflower", "Rose", "Lotus", "Marigold", "Lily", "Jasmin"
                    };
                String[] Info = str;
            foreach (string k in Info)
            {
                Console.WriteLine(k[2]);
            }
        }
    }
}

     
