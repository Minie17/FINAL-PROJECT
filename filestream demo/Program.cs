using System;
using System.IO;

namespace filestreamdemo
{
    class Student
    {
        void details(string ID, string studentname, int studentmarks)

        {
            string details;
            FileStream fs = new FileStream(@"E:/student.txt", FileMode.Append ,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            details = ID + "\t"+ studentname + "\t"+ studentmarks;
            sw.WriteLine(details);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string ID;
            string studentname;
            int studentmarks;
            string resp;
            int i = 0;
            do
            {
                Console.WriteLine("studentID {0} ID:", i);
                ID =Console.ReadLine();
                Console.WriteLine("studentname {0} studentname:", i);
                studentname = Console.ReadLine();
                Console.WriteLine("studentmarks {0} studentmarks:", i);
                studentmarks = Convert.ToInt32(Console.ReadLine());
                Student sfo = new Student ();
                sfo.EnterDetails(ID, studentname, studentmarks);
                Console.WriteLine("press y to cont...");
                resp = Console.ReadLine();

            }
            while (resp == "y");
        }
    }
}
