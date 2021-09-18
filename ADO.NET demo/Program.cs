using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NET_demo
{
    class connect
    {
        public string constr;
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;

        public static void CreateConnection()
        {
            string conn = "Data Source=LAPTOP-0S794175;Initial Catalog=TQdb;Integrated Security=true ";

            con = new SqlConnection();
            con.ConnectionString = conn;
        }
        public static void InsertData(string EnNum, string Name, string location);
        {
         con.open();
             string query = "insert into Student Detalies ('" + EnNum + "','" + Name + "','" + location + "');
            cmd = new SqlCommand(query, con);

        int r = cmd.ExecuteNonQuery();
        Console.WriteLine("{0} of rows affected");
            con.Close();
          }
    public static void DisplayData()
    {
        con.Open();
        string query = "Select * from StudentDetails";
        cmd = new SqlCommand(query, con);
        dr = cmd.ExecuteReader();
        Console.WriteLine("Name \t location");
        while (dr.Read())
        {
            Console.WriteLine("{0} \t {1} ", dr["Name"], dr["location"]);

        }
        dr.Close();
        string cmdcount = "Select count(*) from StudentDetails";
        cmd = new SqlCommand(cmdcount, con);
        int count = (int)cmd.ExecuteScalar();
        Console.WriteLine("{0} Records in the table", count);

        con.Close();
    }
}
class Program
{
    static void Main(string[] args)
    {
        string EnNum;
        string Name;
        string location;
        

        Connect.CreateConnection();

        // Connecting.DisplayData();

        Console.WriteLine("Enter Your details");
        EnNum = Console.ReadLine();
        Name = Console.ReadLine();
        location= Console.ReadLine();
        Connect.InsertData(EnNum, Name, location);

    }
}


