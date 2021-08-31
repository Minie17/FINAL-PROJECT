using System;

namespace pre_and_post_incerement
{
    class Inc
    {
        static void Main()
        {
            int a = 24, b;
            //post increment
            b = a++;
            Console.WriteLine("The value of b is " + b);
            Console.WriteLine("The new value of a is " + a);
            //pre increment
            b = ++a;
            Console.WriteLine("The value of b is" + b);
            Console.WriteLine("The new value of a is " + a);

        }
    }
}
