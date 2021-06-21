using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using SDS_LIB;

namespace SDS_webapp
{
    public partial class Parametrs : SDS_page
    {
        void ChangeLableColorNText(string text, ref Label lb, Color color)
        {
            lb.Text = text;
            lb.ForeColor = color;
        }
        void IMT_cout()
        {
            try
            {
                double h = double.Parse(user_Sport_Data.Height) / 100.0;
                double imt = double.Parse(user_Sport_Data.Weight) / (Math.Pow(h, 2));
                
                if (user_Sport_Data_list.Count > 1)
                {
                    double h2 = double.Parse(user_Sport_Data_list[1].Height) / 100.0;
                    double imt2 = double.Parse(user_Sport_Data_list[1].Weight) / (Math.Pow(h, 2));
                    double result = imt / imt2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta, Color.Red);
                }

                ChangeLableColorNText(imt.ToString(), ref IMT_D, Color.Black);
                if (imt > 40)
                    ChangeLableColorNText("Сильное ожирение", ref IMT_R, Color.DarkRed);
                else if (imt > 30 && imt <= 40)
                    ChangeLableColorNText("Ожирение", ref IMT_R, Color.OrangeRed);
                else if (imt > 25 && imt <= 30)
                    ChangeLableColorNText("Избыточная масса", ref IMT_R, Color.Orange);
                else if (imt >= 20 && imt <= 25)
                    ChangeLableColorNText("Нормальный вес", ref IMT_R, Color.Green);
                else
                    ChangeLableColorNText("Недостаток веса", ref IMT_R, Color.IndianRed);
            }
            catch { }
        }
        void EX_cout()
        {
            try
            {
                int exc = int.Parse(user_Sport_Data.ChestIN) - int.Parse(user_Sport_Data.ChestOUT);

                if (user_Sport_Data_list.Count > 1)
                {
                    double exc2 = double.Parse(user_Sport_Data_list[1].ChestIN) - double.Parse(user_Sport_Data_list[1].ChestOUT);
                    double result = exc / exc2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta0, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta0, Color.Red);
                }

                ChangeLableColorNText(exc.ToString(), ref EX_D, Color.Black);
                if (exc < 5)
                    ChangeLableColorNText("Низкое развитие", ref EX_R, Color.Red);
                else if (exc > 4 && exc < 10)
                    ChangeLableColorNText("Среднее развитие", ref EX_R, Color.Orange);
                else if (exc > 9)
                    ChangeLableColorNText("Высокое развитие", ref EX_R, Color.Green);
            }
            catch { }
        }
        void ER_cout()
        {
            try
            {
                double eris = double.Parse(user_Sport_Data.ChestSTD) - (double.Parse(user_Sport_Data.Height) / 2);

                if (user_Sport_Data_list.Count > 1)
                {
                    double eris2 = double.Parse(user_Sport_Data_list[1].ChestSTD) - (double.Parse(user_Sport_Data_list[1].Height) / 2);
                    double result = eris / eris2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta1, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta1, Color.Red);
                }

                ChangeLableColorNText(eris.ToString(), ref EX_D0, Color.Red);
                if (eris < 0)
                    ChangeLableColorNText("Слабое развитие", ref EX_R0, Color.Red);
                else
                    ChangeLableColorNText("Нормальное развитие", ref EX_R0, Color.Green);
            }
            catch { }
        }
        void ITB_cout()
        {
            try
            {
                double idx = double.Parse(user_Sport_Data.Waist) / double.Parse(user_Sport_Data.Hips);
                double etalon = 0.8;
                if (user_Sport_Data.Gender == "Мужской")
                    etalon = 0.9;

                if (user_Sport_Data_list.Count > 1)
                {
                    double idx2 = double.Parse(user_Sport_Data_list[1].Waist) / double.Parse(user_Sport_Data_list[1].Hips);
                    double result = idx / idx2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta2, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta2, Color.Red);
                }

                ChangeLableColorNText(idx.ToString(), ref ITB_D, Color.Black);
                if (idx <= etalon)
                    ChangeLableColorNText("В пределах нормы", ref IT_R, Color.Green);
                else
                    ChangeLableColorNText("Выше нормы", ref IT_R, Color.Red);
            }
            catch { }
        }
        void KT_cout()
        {
            try
            {
                int idx = int.Parse(user_Sport_Data.Height) - int.Parse(user_Sport_Data.Weight) + int.Parse(user_Sport_Data.ChestSTD);
                if (user_Sport_Data_list.Count > 1)
                {
                    double idx2 = int.Parse(user_Sport_Data_list[1].Height) - int.Parse(user_Sport_Data_list[1].Weight) + int.Parse(user_Sport_Data_list[1].ChestSTD);
                    double result = idx / idx2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta3, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta3, Color.Red);
                }
                ChangeLableColorNText(idx.ToString(), ref KT_D, Color.Black);
                if (idx <= 15)
                    ChangeLableColorNText("Крепкое телосложение", ref KT_R, Color.DarkGreen);
                else if (idx > 15 && idx <= 20)
                    ChangeLableColorNText("Хорошее телосложение", ref KT_R, Color.Green);
                else if (idx > 20 && idx <= 25)
                    ChangeLableColorNText("Среднее телосложение", ref KT_R, Color.Orange);
                else if (idx > 25 && idx <= 30)
                    ChangeLableColorNText("Слабое телосложение", ref KT_R, Color.OrangeRed);
                else
                    ChangeLableColorNText("Очень слабое телосложение", ref KT_R, Color.Red);
            }
            catch { }
        }
        void GEL_cout()
        {
            try
            {
                int idx;
                if (user_Sport_Data.Gender == "Мужской")
                    idx = 40 * int.Parse(user_Sport_Data.Height) + 30 * int.Parse(user_Sport_Data.Weight) - 4400;
                else
                    idx = 40 * int.Parse(user_Sport_Data.Height) + 10 * int.Parse(user_Sport_Data.Weight) - 3800;
                
                double gp = (double)idx / double.Parse(user_Sport_Data.Weight);

                if (user_Sport_Data_list.Count > 1)
                {
                    double idx2;
                    if (user_Sport_Data.Gender == "Мужской")
                        idx2 = 40 * int.Parse(user_Sport_Data_list[1].Height) + 30 * int.Parse(user_Sport_Data_list[1].Weight) - 4400;
                    else
                        idx2 = 40 * int.Parse(user_Sport_Data_list[1].Height) + 10 * int.Parse(user_Sport_Data_list[1].Weight) - 3800;
                    
                    double gp2 = idx2 / double.Parse(user_Sport_Data_list[1].Weight);
                    double result = idx / idx2 * 100 - 100;
                    double result2 = gp / gp2 * 100 - 100;

                    if (result >= 0)
                        ChangeLableColorNText("+" + result.ToString(), ref Delta6, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString(), ref Delta6, Color.Red);

                    if (result2 >= 0)
                        ChangeLableColorNText("+" + result.ToString(), ref Delta7, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString(), ref Delta7, Color.Red);
                }
                ChangeLableColorNText(idx.ToString(), ref GEL_D, Color.Black);
                //ChangeLableColorNText("Допускается отклонение до 15%", ref GEL_R, Color.Black);
                ChangeLableColorNText(gp.ToString(), ref GP_D, Color.Black);
                //ChangeLableColorNText("Допускается отклонение до 15%", ref GP_R, Color.Black);
            }
            catch { }
        }
        void Pulse_cout()
        {
            try
            {
                int up = (int)((220.0 - double.Parse(user_Sport_Data.Years)) * 0.5);
                int down = (int)((220.0 - double.Parse(user_Sport_Data.Years)) * 0.75);

                if (user_Sport_Data_list.Count > 1)
                {
                    double up2 = (int)((220.0 - double.Parse(user_Sport_Data_list[1].Years)) * 0.5);
                    double down2 = (int)((220.0 - double.Parse(user_Sport_Data_list[1].Years)) * 0.75);
                    double result = up / up2 * 100 - 100;
                    double result2 = down2 / down * 100 - 100;

                    if (result >= 0)
                        ChangeLableColorNText("+" + result.ToString(), ref Delta4, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString(), ref Delta4, Color.Red);

                    if (result2 >= 0)
                        ChangeLableColorNText("+" + result.ToString(), ref Delta5, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString(), ref Delta5, Color.Red);
                }

                ChangeLableColorNText(up.ToString(), ref PU_D, Color.Black);
                ChangeLableColorNText(down.ToString(), ref PD_D0, Color.Black);
            }
            catch { }
        }
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
                if (user_Sport_Data_list != null && user_Sport_Data != null)
                {
                    IMT_cout();
                    EX_cout();
                    ER_cout();
                    ITB_cout();
                    KT_cout();
                    GEL_cout();
                    Pulse_cout();
                }
                Client.Close();
            }
            catch { }
        }
    }
}