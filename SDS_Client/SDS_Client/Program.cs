using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SDS_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd;
                //if (user.Master != "YES")
                //{
                    cmd = new SqlCommand("insert into users(login,password,email,master,first_name,last_name,patronymic,phone) values(@login,@password,@email,@master,@first_name,@second_name,@patronymic,@phone)", connection);
                    cmd.Parameters.AddWithValue("@master", "master1");
                //}
                //else
                //    cmd = new SqlCommand("insert into masters(login,password,email,first_name,second_name,patronymic,phone) values(@login,@password,@email,@first_name,@second_name,@patronymic,@phone)", connection);
                cmd.Parameters.AddWithValue("@login", "admin");
                cmd.Parameters.AddWithValue("@password", "admin");
                cmd.Parameters.AddWithValue("@email", "admin");
                cmd.Parameters.AddWithValue("@first_name", "admin");
                cmd.Parameters.AddWithValue("@second_name", "admin");
                cmd.Parameters.AddWithValue("@patronymic", "admin");
                cmd.Parameters.AddWithValue("@phone", "admin");
                if (cmd.ExecuteNonQuery() != 1)
                    Console.WriteLine("SQL failed");
                else
                    Console.WriteLine("SQL Success");
                connection.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.ReadKey();
        }
    }
}
