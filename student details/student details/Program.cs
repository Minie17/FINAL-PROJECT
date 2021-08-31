using System;

namespace student_details
{
    class Program
    { 
           public struct Person
        {
            public string Name;
            public int course_name_ID;
            public int student_ID;
        }
            static void Main(string[] args)
            {
                   Console.WriteLine("Learning Structures!");
                Person p1;
                p1.Name = "Anjali";
                p1.course_name_ID = 2;
                p1.student_ID = 1257;
                Console.WriteLine("The student details are ");
                Console.WriteLine("Name {0} , course Name {1} , student ID {2}", p1.Name, p1.course_name_ID , p1.student_ID);
                Person p2;
                p2.Name = "Neha";
                p2.course_name_ID = 1;
                p2.student_ID = 1258;
                Console.WriteLine("The student details are ");
                Console.WriteLine("Name {0} , course name {1} , student name {2}", p2.Name, p2.course_name_ID, p2.student_ID);

            }

        }
    }
