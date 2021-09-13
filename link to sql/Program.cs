using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link_to_sql
{
    class Program
    {
        static void Main(string[] args)
        {
            string conn = "Data Source=LAPTOP-0S794175;Initial Catalog=TQdb;Integrated Security=true ";
            var dc = new EmployeeDataContext(conn);
            Student newStudent = new Student();
            newStudent.StudentID = 7;
            newStudent.Studentname = "shalini";
            dc.Students.InsertOnSubmit(newStudent);
            dc.SubmitChanges();
            Console.WriteLine("Updated Record");
        }
    }
}
