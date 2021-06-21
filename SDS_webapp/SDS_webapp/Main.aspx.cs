using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDS_LIB;

namespace SDS_webapp
{
    public partial class Main1 : SDS_page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
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
                Client.Close();
            }
            catch { }
        }
    }
}