using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SDS_LIB
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "SDS_service" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class SDS_service : ISDS_service
    {
        public SDS_service()
        {
            Console.WriteLine("SDS_server exemplier created");
        }
        public bool Registration(SDS_user_data user)
        {
            bool fl = true;
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd;
                if (user.Master != "YES")
                {
                    cmd = new SqlCommand("insert into users(login,password,email,master,first_name,last_name,patronymic,phone) values(@login,@password,@email,@master,@first_name,@second_name,@patronymic,@phone)", connection);
                    cmd.Parameters.AddWithValue("@master", user.Master);
                }
                else
                    cmd = new SqlCommand("insert into masters(login,password,email,first_name,second_name,patronymic,phone) values(@login,@password,@email,@first_name,@second_name,@patronymic,@phone)", connection);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@second_name", user.SecondName);
                cmd.Parameters.AddWithValue("@patronymic", user.Patronymic);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                if (cmd.ExecuteNonQuery() != 1)
                    fl = false;
                connection.Close();
                return fl;
            }
            catch (Exception) { }
            return false;
        }

        public bool Login(string login, string password)
        {
            bool fl = true;
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from users where login = @name and password = @pass", connection);
                cmd.Parameters.AddWithValue("@name", login);
                cmd.Parameters.AddWithValue("@pass", password);
                //SqlCommand cmd1 = new SqlCommand("select * from masters where login = @name and password = @pass", connection);
                //cmd1.Parameters.AddWithValue("@name", login);
                //cmd1.Parameters.AddWithValue("@pass", password);
                SqlDataReader reader1 = cmd.ExecuteReader();
                //SqlDataReader reader2 = cmd1.ExecuteReader();
                if (!reader1.HasRows/* && !reader2.HasRows*/)
                    fl = false;
                reader1.Close();
                //reader2.Close();
                connection.Close();
                return fl;
            }
            catch (Exception) { }
            return false;
        }

        public bool FindLogin(string login)
        {
            bool fl = false;
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from users where login = @name", connection);
                cmd.Parameters.AddWithValue("@name", login);
                SqlCommand cmd1 = new SqlCommand("select * from masters where login = @name", connection);
                cmd1.Parameters.AddWithValue("@name", login);
                SqlDataReader reader1 = cmd.ExecuteReader();
                SqlDataReader reader2 = cmd1.ExecuteReader();
                if (!reader1.HasRows && !reader2.HasRows)
                    fl = true;
                reader1.Close();
                reader2.Close();
                connection.Close();
                return fl;
            }
            catch (Exception) { }
            return false;
        }

        public bool ChangeSportData(SDS_user_sport_data data)
        {
            bool fl = true;
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into data(login,date,height,weight,chest_std,chest_in,chest_out,waist,hips,years,gender,smg) values(@login,@date,@height,@weight,@chest_std,@chest_in,@chest_out,@waist,@hips,@years,@gender,@smg)", connection);
                cmd.Parameters.AddWithValue("@login", data.Login);
                cmd.Parameters.AddWithValue("@date", data.Date);
                cmd.Parameters.AddWithValue("@height", data.Height);
                cmd.Parameters.AddWithValue("@weight", data.Weight);
                cmd.Parameters.AddWithValue("@chest_std", data.ChestSTD);
                cmd.Parameters.AddWithValue("@chest_in", data.ChestIN);
                cmd.Parameters.AddWithValue("@chest_out", data.ChestOUT);
                cmd.Parameters.AddWithValue("@waist", data.Waist);
                cmd.Parameters.AddWithValue("@hips", data.Hips);
                cmd.Parameters.AddWithValue("@gender", data.Gender);
                cmd.Parameters.AddWithValue("@years", data.Years);
                cmd.Parameters.AddWithValue("@smg", data.SpecialGroup);
                if (cmd.ExecuteNonQuery() != 1)
                    fl = false;
                connection.Close();
                return fl;
            }
            catch (Exception e) 
            {
                fl = false;
                Console.WriteLine(e.Message);
            }
            return fl;
        }

        public bool ChangeUserData(SDS_user_data user)
        {
            bool fl = true;
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd;
                if (user.Master != "YES")
                {
                    cmd = new SqlCommand("insert into users(login,password,email,master,first_name,last_name,patronymic,phone) values(@login,@password,@email,@master,@second_name,@last_name,@patronymic,@phone)", connection);
                    cmd.Parameters.AddWithValue("@master", user.Master);
                }
                else
                    cmd = new SqlCommand("insert into masters(login,password,email,first_name,second_name,patronymic,phone) values(@login,@password,@email,@first_name,@second_name,@patronymic,@phone)", connection);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@second_name", user.SecondName);
                cmd.Parameters.AddWithValue("@patronymic", user.Patronymic);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                if (cmd.ExecuteNonQuery() != 1)
                    fl = false;
                connection.Close();
                return fl;
            }
            catch (Exception) { }
            return true;
        }

        public bool ChangeNormesData(SDS_user_normes data)
        {
            bool fl = true;
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into normes(login,date,run_100m,cross_run,pull_up,push_ups,press,forward_bend,jump,swimming,ski,kettlebell) values(@login,@date,@run_100m,@cross,@pull_up,@push_ups,@press,@forward_bend,@jump,@swimming,@ski,@kettlebell)", connection);
                cmd.Parameters.AddWithValue("@login", data.Login);
                cmd.Parameters.AddWithValue("@date", data.Date);
                cmd.Parameters.AddWithValue("@run_100m", data.Run_100m);
                cmd.Parameters.AddWithValue("@cross", data.Cross);
                cmd.Parameters.AddWithValue("@pull_up", data.Pull_up);
                cmd.Parameters.AddWithValue("@push_ups", data.Push_ups);
                cmd.Parameters.AddWithValue("@press", data.Press);
                cmd.Parameters.AddWithValue("@forward_bend", data.Forward_bend);
                cmd.Parameters.AddWithValue("@jump", data.Jump);
                cmd.Parameters.AddWithValue("@swimming", data.Swimming);
                cmd.Parameters.AddWithValue("@ski", data.Ski);
                cmd.Parameters.AddWithValue("@kettlebell", data.Kettlebell);
                if (cmd.ExecuteNonQuery() != 1)
                    fl = false;
                connection.Close();
                return fl;
            }
            catch (Exception ex)
            {
                fl = false;
            }
            return fl;
        }

        public bool ChangeAdditionalData(SDS_user_additional_data data)
        {
            bool fl = true;
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into data_additional(login,date,still_pulse,pulse_20squats,pulse_1min,pulse_2min,pulse_3min,step_pulse,step_pulse_2m,step_pulse_3m,stange,ghenci,kuper) values(@login,@date,@stil_pulse,@pulse_20squats,@pulse_1min,@pulse_2min,@pulse_3min,@step_pulse,@step_pulse_2m,@step_pulse_3m,@shtange,@ghenci,@kuper)", connection);
                cmd.Parameters.AddWithValue("@login", data.Login);
                cmd.Parameters.AddWithValue("@date", data.Date);
                cmd.Parameters.AddWithValue("@stil_pulse", data.Stil_pulse);
                cmd.Parameters.AddWithValue("@pulse_20squats", data.Pulse_20squats);
                cmd.Parameters.AddWithValue("@pulse_1min", data.Pulse_1min);
                cmd.Parameters.AddWithValue("@pulse_2min", data.Pulse_2min);
                cmd.Parameters.AddWithValue("@pulse_3min", data.Pulse_3min);
                cmd.Parameters.AddWithValue("@step_pulse", data.Step_pulse);
                cmd.Parameters.AddWithValue("@step_pulse_2m", data.Step_pulse_2m);
                cmd.Parameters.AddWithValue("@step_pulse_3m", data.Step_pulse_3m);
                cmd.Parameters.AddWithValue("@shtange", data.Stange);
                cmd.Parameters.AddWithValue("@ghenci", data.Ghenci);
                cmd.Parameters.AddWithValue("@kuper", data.Kuper);
                if (cmd.ExecuteNonQuery() != 1)
                    fl = false;
                connection.Close();
                return fl;
            }
            catch (Exception ex) 
            {
                fl = false;
                Console.WriteLine(ex.Message);
            }
            return fl;
        }

        public List<SDS_user_sport_data> GetAllData(string login)
        {
            try
            {
                List<SDS_user_sport_data> lst = new List<SDS_user_sport_data>();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from data where login = @login;", connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SDS_user_sport_data data = new SDS_user_sport_data();
                        data.Login = (string)reader[0];
                        data.Date = (string)reader[1];
                        data.Height = (string)reader[2];
                        data.Weight = (string)reader[3];
                        data.ChestSTD = (string)reader[4];
                        data.ChestIN = (string)reader[5];
                        data.ChestOUT = (string)reader[6];
                        data.Waist = (string)reader[7];
                        data.Hips = (string)reader[8];
                        data.Years = (string)reader[9];
                        data.SpecialGroup = (string)reader[10];
                        lst.Add(data);
                    }
                    lst.Reverse();
                    return lst;
                }
            }
            catch (Exception) { }
            return null;
        }

        public SDS_user_sport_data GetLastData(string login)
        {
            try
            {
                SDS_user_sport_data data = new SDS_user_sport_data();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from data where login = @login;", connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                data.Date = "0000.00.00.00.00.00";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (string.Compare(data.Date, (string)reader[1]) < 0)
                        {
                            data.Login = (string)reader[0];
                            data.Date = (string)reader[1];
                            data.Height = (string)reader[2];
                            data.Weight = (string)reader[3];
                            data.ChestSTD = (string)reader[4];
                            data.ChestIN = (string)reader[5];
                            data.ChestOUT = (string)reader[6];
                            data.Waist = (string)reader[7];
                            data.Hips = (string)reader[8];
                            data.Years = (string)reader[9];
                            data.Gender = (string)reader[10];
                            data.SpecialGroup = (string)reader[11];
                        }
                    }
                    return data;
                }
            }
            catch(Exception) { }
            return null;
        }

        public SDS_user_additional_data GetLastAdditionalData(string login)
        {
            try
            {
                SDS_user_additional_data data = new SDS_user_additional_data();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from data_additional where login = @login;", connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                data.Date = "0000.00.00.00.00.00";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (string.Compare(data.Date, (string)reader[1]) < 0)
                        {
                            data.Login = (string)reader[0];
                            data.Date = (string)reader[1];
                            data.Stil_pulse = (string)reader[2];
                            data.Pulse_20squats = (string)reader[3];
                            data.Pulse_1min = (string)reader[4];
                            data.Pulse_2min = (string)reader[5];
                            data.Pulse_3min = (string)reader[6];
                            data.Step_pulse = (string)reader[7];
                            data.Step_pulse_2m = (string)reader[8];
                            data.Step_pulse_3m = (string)reader[9];
                            data.Stange = (string)reader[10];
                            data.Ghenci = (string)reader[11];
                            data.Kuper = (string)reader[12];
                        }
                    }
                    return data;
                }
            }
            catch (Exception) { }
            return null;
        }

        public List<SDS_user_additional_data> GetAllAdditionalData(string login)
        {
            try
            {
                List<SDS_user_additional_data> lst = new List<SDS_user_additional_data>();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from data_additional where login = @login;", connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SDS_user_additional_data data = new SDS_user_additional_data();
                        data.Login = (string)reader[0];
                        data.Date = (string)reader[1];
                        data.Stil_pulse = (string)reader[2];
                        data.Pulse_20squats = (string)reader[3];
                        data.Pulse_1min = (string)reader[4];
                        data.Pulse_2min = (string)reader[5];
                        data.Pulse_3min = (string)reader[6];
                        data.Step_pulse = (string)reader[7];
                        data.Step_pulse_2m = (string)reader[8];
                        data.Step_pulse_3m = (string)reader[9];
                        data.Stange = (string)reader[10];
                        data.Ghenci = (string)reader[11];
                        data.Kuper = (string)reader[12];
                        lst.Add(data);
                    }
                    lst.Reverse();
                    return lst;
                }
            }
            catch (Exception) { }
            return null;
        }

        public SDS_user_normes GetLastNormes(string login)
        {
            try
            {
                SDS_user_normes data = new SDS_user_normes();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from normes where login = @login;", connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                data.Date = "0000.00.00.00.00.00";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (string.Compare(data.Date, (string)reader[1]) < 0)
                        {
                            data.Login = (string)reader[0];
                            data.Date = (string)reader[1];
                            data.Run_100m = (string)reader[2];
                            data.Cross = (string)reader[3];
                            data.Pull_up = (string)reader[4];
                            data.Push_ups = (string)reader[5];
                            data.Press = (string)reader[6];
                            data.Forward_bend = (string)reader[7];
                            data.Jump = (string)reader[8];
                            data.Swimming = (string)reader[9];
                            data.Ski = (string)reader[10];
                            data.Kettlebell = (string)reader[11];
                        }
                    }
                    return data;
                }
            }
            catch (Exception) { }
            return null;
        }

        public List<SDS_user_normes> GetAllNormes(string login)
        {
            try
            {
                List<SDS_user_normes> lst = new List<SDS_user_normes>();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from data where login = @login;", connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SDS_user_normes data = new SDS_user_normes();
                        data.Login = (string)reader[0];
                        data.Date = (string)reader[1];
                        data.Run_100m = (string)reader[2];
                        data.Cross = (string)reader[3];
                        data.Pull_up = (string)reader[4];
                        data.Push_ups = (string)reader[5];
                        data.Press = (string)reader[6];
                        data.Forward_bend = (string)reader[7];
                        data.Jump = (string)reader[8];
                        data.Swimming = (string)reader[9];
                        data.Ski = (string)reader[10];
                        data.Kettlebell = (string)reader[11];
                        lst.Add(data);
                    }
                    lst.Reverse();
                    return lst;
                }
            }
            catch (Exception) { }
            return null;
        }

        public List<SDS_user_data> GetMasters(string login)
        {
            try
            {
                List<SDS_user_data> lst = new List<SDS_user_data>();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from Masters;", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SDS_user_data data = new SDS_user_data();
                        data.Login = (string)reader[0];
                        data.Password = string.Empty;
                        data.Email = (string)reader[2];
                        data.Phone = (string)reader[3];
                        data.FirstName = (string)reader[4];
                        data.SecondName = (string)reader[5];
                        data.Patronymic = (string)reader[6];
                        data.Master = "YES";
                        lst.Add(data);
                    }
                    return lst;
                }
            }
            catch { }
            return null;
        }

        public SDS_user_data GetMyData(string login)
        {
            try
            {
                SDS_user_data lst = new SDS_user_data();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from users where login = @name;", connection);
                cmd.Parameters.AddWithValue("@name", login);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lst.Login = (string)reader[0];
                    lst.Password = string.Empty;
                    lst.Email = (string)reader[2];
                    lst.Master = (string)reader[3];
                    lst.FirstName = (string)reader[4];
                    lst.SecondName = (string)reader[5];
                    lst.Patronymic = (string)reader[6];
                    lst.Phone = (string)reader[7];
                }
                return lst;
            }
            catch { }
            return null;
        }

        public SDS_user_data GetMyMaster(string login)
        {
            try
            {
                SDS_user_data lst = new SDS_user_data();
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0CCBF4B\\SQLEXPRESS;Initial Catalog=SDS_DATA;Integrated Security=SSPI;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from masters where login = @login;", connection);
                cmd.Parameters.AddWithValue("@login", login);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lst.Login = (string)reader[0];
                    lst.Password = string.Empty;
                    lst.Email = (string)reader[2];
                    lst.Phone = (string)reader[3];
                    lst.FirstName = (string)reader[4];
                    lst.SecondName = (string)reader[5];
                    lst.Patronymic = (string)reader[6];
                    lst.Master = "YES";
                }
                return lst;
            }
            catch { }
            return null;
        }
    }
}
