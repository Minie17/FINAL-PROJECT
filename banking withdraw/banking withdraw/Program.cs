using System;

namespace banking_withdraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000 ,withdrawal;
            string customer_name;
            Console.WriteLine("Name of customer:");
            customer_name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("withdrawal amount:");
            withdrawal = Convert.ToInt32(Console.ReadLine());
            balance = withdrawal > balance ? balance : balance - withdrawal;
            Console.WriteLine("Console name: " + customer_name);
            Console.WriteLine("Remaining Balance:" + balance);



        }
    }
}
