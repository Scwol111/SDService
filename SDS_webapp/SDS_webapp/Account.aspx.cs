using System;
using System.Collections.Generic;
using SDS_LIB;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDS_webapp
{
    public partial class Account : SDS_page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SDS_user_additional_data[] dl;
            SDS_user_normes[] nr;
            SDS_user_sport_data[] sp;
            try
            {
                SDS_page page = PreviousPage as SDS_page;
                Client = new SDS_serviceClient();
                Client.Open();
                //if (page != null)
                    login = GetLogin;
                additional_Data = Client.GetLastAdditionalData(login);
                dl = Client.GetAllAdditionalData(login);
                if (dl != null)
                    additional_Data_list = new List<SDS_user_additional_data>(dl);
                else
                    additional_Data_list = null;
                user_Normes = Client.GetLastNormes(login);
                nr = Client.GetAllNormes(login);
                if (nr != null)
                    user_Normes_list = new List<SDS_user_normes>(nr);
                else
                    user_Normes_list = null;
                user_Sport_Data = Client.GetLastData(login);
                sp = Client.GetAllData(login);
                if (sp != null)
                    user_Sport_Data_list = new List<SDS_user_sport_data>(sp);
                else
                    user_Sport_Data_list = null;
                data = Client.GetMyData(login);
                if (data != null)
                {
                    FIO.Text = data.SecondName + " " + data.FirstName + " " + data.Patronymic;
                    Mail.Text = data.Email;
                    SDS_user_data master = Client.GetMyMaster(data.Master);
                    Master.Text = master.SecondName + " " + master.FirstName + " " + master.Patronymic;
                    Phone.Text = data.Phone;
                }
            }
            catch(Exception ex) { Label2.Text = ex.Message; }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("ChangeAccountData.aspx", true);
            }
            catch { }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("FizParam.aspx", true);
            }
            catch { }
        }
    }
}