using System;
using System.Collections.Generic;
using SDS_LIB;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDS_webapp
{
    public partial class ChangeAccountData : SDS_page
    {
        List<SDS_user_data> masters;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DropDownList1.Items.Clear();
                SDS_page page = PreviousPage as SDS_page;
                Client = new SDS_serviceClient();
                Client.Open();
                if (page != null)
                    login = page.GetLogin;
                additional_Data = Client.GetLastAdditionalData(login);
                additional_Data_list = new List<SDS_user_additional_data>(Client.GetAllAdditionalData(login));
                user_Normes = Client.GetLastNormes(login);
                user_Normes_list = new List<SDS_user_normes>(Client.GetAllNormes(login));
                user_Sport_Data = Client.GetLastData(login);
                user_Sport_Data_list = new List<SDS_user_sport_data>(Client.GetAllData(login));
                data = Client.GetMyData(login);
                masters = new List<SDS_user_data>(Client.GetMasters("login"));
                for (int i = 0; i < masters.Count; i++)
                    DropDownList1.Items.Add(masters[i].SecondName + " " + masters[i].FirstName + " " + masters[i].Patronymic);
                if (data != null)
                {
                    Fam.Text = data.SecondName;
                    User_name.Text = data.FirstName;
                    User_otch.Text = data.Patronymic;
                    mail.Text = data.Email;
                    Phone.Text = data.Phone;
                }
                Client.Close();
            }
            catch { }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("Account.aspx", true);
            }
            catch { }
        }
    }
}