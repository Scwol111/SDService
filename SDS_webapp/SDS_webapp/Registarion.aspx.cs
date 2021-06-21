using System;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using SDS_LIB;

namespace SDS_webapp
{
    public partial class Registarion : SDS_page
    {
        List<SDS_user_data> masters;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DropDownList1.Items.Clear();
                Client = new SDS_serviceClient();
                Client.Open();
                masters = new List<SDS_user_data>(Client.GetMasters("login"));
                for (int i = 0; i < masters.Count; i++)
                    DropDownList1.Items.Add(masters[i].SecondName + " " + masters[i].FirstName + " " + masters[i].Patronymic);
            }
            catch { }
        }
        void SendToMail()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("no-reply_sds_service@inbox.ru");
                message.To.Add(new MailAddress(mail.Text));
                message.Subject = "Регистрация в системе электронного дневника самоуонтроля";
                message.IsBodyHtml = true;
                message.Body = "<html><head><title>Регистрация в системе электроннаго дневника самоконтроля</title></head>" +
                    "<body><h1>Спасибо за регистацию</h1><br>" + User_name.Text + " " + User_otch.Text +
                    "<br>Благодарим вас за регистрацию в системе электронного дневника самоконтроля<br>" + 
                    "Ваш логин в системе: " + Name.Text + "</body></html>";
                smtp.Port = 587;
                smtp.Host = "smtp.mail.ru";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("no-reply_sds_service@inbox.ru", "4SsQgyzzfMmwcIkbPhZG");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch { }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label13.Visible = false;
            Label12.Visible = false;
            Label15.Visible = false;
            MD5 d5 = MD5.Create();
            SHA512 sh = SHA512.Create();
            string pass1 = Request["Password1"];
            string pass2 = Request["Password2"];
            try
            {
                if (pass1.Length > 0 && pass1 == pass2)
                {
                    if (!Client.FindLogin(Name.Text))
                    {
                        login = Name.Text;
                        SDS_user_data new_user = new SDS_user_data();
                        new_user.Login = Name.Text;
                        //pass1 = pass2 + Encoding.ASCII.GetString(d5.ComputeHash(Encoding.ASCII.GetBytes(Name.Text)));
                        //new_user.Password = Encoding.ASCII.GetString(sh.ComputeHash(Encoding.ASCII.GetBytes(pass1)));
                        new_user.Password = pass1;
                        new_user.Email = mail.Text;
                        new_user.SecondName = Fam.Text;
                        new_user.FirstName = User_name.Text;
                        new_user.Patronymic = User_otch.Text;
                        new_user.Master = masters[DropDownList1.SelectedIndex].Login;
                        new_user.Phone = TextBox1.Text;
                        if (!Client.Registration(new_user))
                            throw new Exception();
                        SendToMail();
                        Client.Close();
                        Server.Transfer("Main.aspx", true);
                    }
                    else
                        Label12.Visible = true;
                    Client.Close();
                }
                else
                    Label13.Visible = true;
            }
            catch (Exception ex)
            {
                Label15.Visible = true;
            }
        }
    }
}