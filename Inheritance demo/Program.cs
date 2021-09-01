using System;

namespace Inheritance_demo
{
    class Program
    {
        static void Main(string[] args)
        { }
       
            public class User
            { 
            public string  firstName;
            private string Identity;
            public User()
            {
                Console.WriteLine("Base Class Constructor");
            }
            public void GetUserInfo(string ID)
            {
                Identity = ID;
                Console.WriteLine("firstName: {0}", firstName);
                Console.WriteLine("Identity: {0}", Identity);
            }
        }
        public class Details : User
        {
            public int Age;
            public Details()
            {
                Console.WriteLine("Child Class Constructor");
            }
            public void GetAge()
            {
                Console.WriteLine("Age: {0}", Age);
            }
        }
        class student
        {
            static void Main(string[] args)
            {
                Details d = new Details();
                d.firstName = "Chaitrali";
                d.Age= 23;
                d.GetUserInfo("Hyderabad");
                d.GetAge();
                Console.WriteLine("\nPress Any Key to Exit..");
                Console.ReadLine();
            }
        }
    }
}

   
