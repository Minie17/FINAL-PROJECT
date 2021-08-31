using System;

namespace charater_data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Char ch;
            Console.WriteLine("enter any alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch=='A'|| ch=='a'|| ch=='E' || ch=='e' || ch=='i' || ch=='I'|| ch=='O'|| ch=='o'|| ch=='U'|| ch=='u')
            {
                Console.WriteLine("The charater entered is a vowal");
            }
            else
            {
                Console.WriteLine("The charater entered is consonant");
            }
        }
    }
}
