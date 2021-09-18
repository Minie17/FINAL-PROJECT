using System;
using System.Data.SqlClient;

namespace RestroConnection
{
    public class rest
    {
        public string constr;
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        public string sd;
        public string rd;
        DateTime openingtime;
        DateTime closingtime;

        public static void CreateConnection()
        {
            string constr = "Data Source=localhost; Initial Catalog=Restaurentdb;Integrated Security=SSPI";

            con = new SqlConnection();
            con.ConnectionString = constr;
            Console.WriteLine("Connection with data base succesfull");
        }
        public static void InsertData(string Name, DateTime openingtime, DateTime closingtime, string phonenumber, string address,string cuision)
        {
            con.Open();

            string query = "insert into RestoSystem values(@N,@ot,@ct,@pn,@add,@cu)";

            cmd = new SqlCommand(query, con);

            cmd.Parameters.Add(new SqlParameter("N", Name));
            cmd.Parameters.Add(new SqlParameter("ot", openingtime));
            cmd.Parameters.Add(new SqlParameter("ct", closingtime));
            cmd.Parameters.Add(new SqlParameter("pn", phonenumber));
            cmd.Parameters.Add(new SqlParameter("add", address));
            cmd.Parameters.Add(new SqlParameter("cu", cuision));


            int r = cmd.ExecuteNonQuery();
            Console.WriteLine("{0} of rows affected", r);
            con.Close();

        }
        //Delete
        /*public static void DeleteData(string Name)
        {
            con.Open();
            string que = "Delete from RestoSystem where  Name=@Name";
            cmd = new SqlCommand(que, con);
            cmd.Parameters.Add(new SqlParameter("Name", "Hotal rubi"));
            int g = cmd.ExcuteNonQuery();
            Console.WriteLine("Deleted row!"+g);
            Console.ReadLine();
            con.Close();
        }*/
        //Delete
        public static void DeleteData(string Name)
        {
            con.Open();
            SqlCommand deleteCommand = new SqlCommand("Delete from RestoSystem where Name=@N", con);
            deleteCommand.Parameters.Add(new SqlParameter("N", Name));
            Console.WriteLine("Commands executed total rows affected are" + deleteCommand.ExecuteNonQuery());
            Console.WriteLine("press enter to move to the next step");
            Console.ReadLine();

            con.Close();
        }

        //Update
        /* public static void Updatedata(string Name,DateTime openingtime,DateTime closingtime)
         {
             con.Open();
             string query = "Update details of an restorent such as Name=@N, openingtime=@ot,closingtime=@ct";
             cmd = new SqlCommand(query, con);
             cmd.Parameters.Add(new SqlParameter("Name", "HotalRoshni"));
             cmd.Parameters.Add(new SqlParameter("openingtime", "11:00"));
             cmd.Parameters.Add(new SqlParameter("closingtime", "18:00"));
             Console.WriteLine("commands executed!Total rows affected are" + cmd.ExcuteNonQuery());
             Console.WriteLine("Done!Press enter to move to the next step");
             Console.ReadLine();
             con.Close();
         }*/
        //update
        public static void updatedata(string Name, DateTime openingtime, DateTime closingtime, string phonenumber, string address,string cuision)
        {
            con.Open();
            SqlCommand updateCommand = new SqlCommand("Update  RestoSystem set  Name=@N ,openingtime=@ot,closingtime=@ct,phonenumber=@pn,address=@addr,cuision=@cu", con);
            updateCommand.Parameters.Add(new SqlParameter("N", Name));
            updateCommand.Parameters.Add(new SqlParameter("ot", openingtime));
            updateCommand.Parameters.Add(new SqlParameter("ct", closingtime));
            updateCommand.Parameters.Add(new SqlParameter("pn", phonenumber));
            updateCommand.Parameters.Add(new SqlParameter("addr", address));
            updateCommand.Parameters.Add(new SqlParameter("cu", cuision));
            dr = updateCommand.ExecuteReader();
            Console.WriteLine("Name\t openingtime \t closingtime\tphonenumber\taddress\tcuision");
           while (dr.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",dr["Name"],dr["openingtime"],dr["closingtime"],dr["phonenumber"],dr["address"],dr["cuision"]);

            }
            dr.Close();
            Console.WriteLine("Commands executed! Total rows affected are " + updateCommand.ExecuteNonQuery());
            Console.WriteLine("Press enter to move to the next step");
            Console.ReadLine();
            con.Close();

        }
        //Display
        public static void DisplayData()
        {
            con.Open();
            string query = "Select * from RestoSystem";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Name \t openingtime \t closingtime \t phonenumber \t address \t cuision");
            while (dr.Read())
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} ", 
                    dr["Name"], dr["openingtime"],dr["closingtime"],dr["phonenumber"],dr["address"],dr["cuision"]);

            }
            dr.Close();
            string cmdcount = "Select count (*) from RestoSystem";
            cmd = new SqlCommand(cmdcount, con);
            int count = (int)cmd.ExecuteScalar();
            Console.WriteLine("{0} Records in the table", count);
            Console.WriteLine("press enter for next step");
            Console.ReadLine();

            con.Close();
        }
        

            

    }


 }


