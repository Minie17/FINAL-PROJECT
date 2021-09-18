using System;
using RestroConnection;
using RestroFunction;
using System.Text.RegularExpressions;

namespace RestorentSystemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            rest.CreateConnection();
            // rest.DisplayData();
            string input, Add;
        R:
            Console.WriteLine("********Welcome to Restorent System***********");
            Console.WriteLine("**********************************************");
            Console.WriteLine("I. Insert Details of Restorent");
            Console.WriteLine("U. Update details of the restorent ");
            Console.WriteLine("D. Delete the restorent");
            Console.WriteLine("DI. Display details of Restorent");
            Console.WriteLine("E . Exit from table");
            Console.WriteLine("**********************************************");
            input = Console.ReadLine();

            string Name;
            DateTime ot;
            DateTime ct;
            string phonenumber;
            string address;
            string cuision;
            switch (input)
            {
                case "I":


                    Console.WriteLine("Enter your Details");
                    Console.WriteLine("Enter the Name:");
                    Name = Console.ReadLine();
                    while(string.IsNullOrEmpty(Name))
                    {
                        Console.WriteLine("please enter the student name it cannotb be empty");
                        Console.WriteLine("Enter the Name again");
                        Name = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the openingtime in hh:mm");
                    ot = Convert.ToDateTime(Console.ReadLine());
                    //ot = DateTime.ParseExact(ot,"hh:mm",null);
                    Console.WriteLine("Enter the closingtime in hh:mm");
                    ct = Convert.ToDateTime(Console.ReadLine());
                    //ct = DateTime.ParseExact(ct,"hh:mm",null);
                    Console.WriteLine("Enter the phoneNumber:");
                    phonenumber = Console.ReadLine();
                    Console.WriteLine("Enter the Address:");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter the cuision:");
                    cuision = Console.ReadLine();
                    rest.InsertData(Name, ot, ct, phonenumber, address, cuision);
                    goto R;

               

                
                case "U":
                    Console.WriteLine("Enter the for update Restorent");
                    Console.WriteLine("Enter Restorent Name : ");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter opening time of the Restorent:");
                    ot = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter closing time of the Restorent:");
                    ct = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter phonenumber of the restorent:");
                    phonenumber = Console.ReadLine();
                    Console.WriteLine("Enter the restorent address");
                    Add = Console.ReadLine();
                    Console.WriteLine("Enter the cuision:");
                    cuision = Console.ReadLine();
                    rest.updatedata(Name, ot, ct, phonenumber, Add,cuision);
                   // rest.DisplayRestoData();
                    goto R;

                case "D":
                    Console.WriteLine("Enter Name to delete the data:");
                    Name = Console.ReadLine();
                    rest.DeleteData( Name);
                   // rest.DisplayRestoData();
                    goto R;
                case "DI":
                    rest.DisplayData();
                    goto R;
                
                case "E":
                    //rest.ExitRestoSystem();
                    break;

                default:
                    Console.WriteLine("Enter correct Details");
                    goto R;





            }
        }
    }
}
