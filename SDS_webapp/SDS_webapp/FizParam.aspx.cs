using System;
using System.Collections.Generic;
using SDS_LIB;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDS_webapp
{
    public partial class FizParam : SDS_page
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
                if (user_Sport_Data != null)
                {
                    Height.Text = user_Sport_Data.Height;
                    Weight.Text = user_Sport_Data.Weight;
                    ChestSTD.Text = user_Sport_Data.ChestSTD;
                    ChestIN.Text = user_Sport_Data.ChestIN;
                    ChestOUT.Text = user_Sport_Data.ChestOUT;
                    Waist.Text = user_Sport_Data.Waist;
                    Hips.Text = user_Sport_Data.Hips;
                    Years.Text = user_Sport_Data.Years;
                    if (user_Sport_Data.Gender == "Мужской")
                        Gender.SelectedValue = "Мужской";
                    else
                        Gender.SelectedValue = "Женский";
                    if (user_Sport_Data.SpecialGroup == "YES")
                        SMG.Checked = true;
                }
                Client.Close();
            }
            catch { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Good.Visible = true;
            try
            {
                Client = new SDS_serviceClient();
                Client.Open();
                SDS_user_sport_data sport = new SDS_user_sport_data();
                sport.Login = login;
                sport.ChestIN = ChestIN.Text;
                sport.ChestOUT = ChestOUT.Text;
                sport.ChestSTD = ChestSTD.Text;
                sport.Gender = Gender.SelectedValue;
                sport.Height = Height.Text;
                sport.Hips = Hips.Text;
                sport.Waist = Waist.Text;
                sport.SpecialGroup = "NO";
                if (SMG.Checked)
                    sport.SpecialGroup = "YES";
                sport.Weight = Weight.Text;
                sport.Years = Years.Text;
                DateTime time = DateTime.Now;
                sport.Date = time.Year.ToString() + "." + time.Month.ToString() + "." + time.Day.ToString() + "." + 
                    time.Hour.ToString() + "." + time.Minute.ToString() + "." + time.Second.ToString();
                if (!Client.ChangeSportData(sport))
                    throw new Exception();
                Client.Close();
            }
            catch 
            {
                Good.Text = "Во время сохранения произошла ошибка, попробуйте позже";
                Good.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}