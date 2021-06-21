using System;
using System.Text;
using System.ServiceModel;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDS_webapp
{
    public partial class login : SDS_page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Client = new SDS_serviceClient();
            }
            catch (Exception ex) 
            {
                Label4.Text = ex.Message;
                Label4.ForeColor = System.Drawing.Color.Green;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label4.Visible = false;
            try
            {
                Client.Open();
                MD5 d5 = MD5.Create();
                SHA512 sh = SHA512.Create();
                string str = Request["Password1"];
                //string pass = str + Encoding.ASCII.GetString(d5.ComputeHash(Encoding.ASCII.GetBytes(Name.Text)));
                string pass = str;
                if (str.Length > 0)
                {
                    if (Client.Login(Name.Text, pass/*Encoding.ASCII.GetString(sh.ComputeHash(Encoding.ASCII.GetBytes(pass)))*/))
                    {
                        login = Name.Text;
                        Client.Close();
                        Server.Transfer("Main.aspx", true); 
                    }
                    else
                        throw new Exception("Введены неверные имя пользователя или пароль");
                }
                else
                    throw new Exception("Введены неверные имя пользователя или пароль");
            }
            catch (Exception ex)
            {
                Label4.Visible = true;
                Label4.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registarion.aspx", true);
        }
    }
}