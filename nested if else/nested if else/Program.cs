using System;

namespace nested_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter any day in number");
            day = Convert.ToInt32(Console.ReadLine());
            if(day == 1)
            {
                Console.WriteLine("It is Monday");
            }
            else if(day == 2)
            {
                Console.WriteLine("It is Tusday");
            }
            else if(day == 3)
                {   
                Console.WriteLine("Day is Wednesday");
            }
            else if(day == 4)
            {
                Console.WriteLine("this day is Thusday");
            }
            else if(day == 5)
            {
                Console.WriteLine("day is friday");
            }
            else
            {
                Console.WriteLine("Incorrect day");
            }
        }
    }
}
