using System;
using System.Drawing;
using System.Collections.Generic;
using SDS_LIB;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDS_webapp
{
    public partial class AdditionalParams : SDS_page
    {
        void ChangeLableColorNText(string text, ref Label lb, Color color)
        {
            lb.Text = text;
            lb.ForeColor = color;
        }
        void Kuper()
        {
            try
            {
                double res = double.Parse(Kuper_D.Text);
                int years = int.Parse(user_Sport_Data.Years);

                if (additional_Data_list.Count > 1)
                {
                    double res2 = double.Parse(additional_Data_list[1].Kuper) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Kuper_Delta, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Kuper_Delta, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (years <= 14)
                    {
                        if (res < 2100)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 2100 && res < 2200)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 2200 && res < 2400)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2400 && res < 2700)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2700)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 15 && years <= 16)
                    {
                        if (res < 2200)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 2200 && res < 2300)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 2300 && res < 2500)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2500 && res < 2800)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2800)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 17 && years <= 19)
                    {
                        if (res < 2300)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 2300 && res < 2500)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 2500 && res < 2700)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2700 && res < 3000)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 3000)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 20 && years <= 29)
                    {
                        if (res < 1600)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1600 && res < 2200)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 2200 && res < 2400)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2400 && res < 2800)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2800)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 30 && years <= 39)
                    {
                        if (res < 1500)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1500 && res < 1900)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1900 && res < 2300)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2300 && res < 2700)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2700)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 40 && years <= 49)
                    {
                        if (res < 1400)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1400 && res < 1700)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1700 && res < 2100)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2100 && res < 2500)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2700)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years > 50)
                    {
                        if (res < 1300)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1300 && res < 1600)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1600 && res < 2000)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2000 && res < 2400)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2400)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                }
                else
                {
                    if (years <= 14)
                    {
                        if (res < 1500)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1500 && res < 1600)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1600 && res < 1900)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 1900 && res < 2000)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2000)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 15 && years <= 16)
                    {
                        if (res < 1600)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1600 && res < 1700)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1700 && res < 2000)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2000 && res < 2100)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2100)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 17 && years <= 19)
                    {
                        if (res < 1700)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1700 && res < 1800)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1800 && res < 2100)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2100 && res < 2300)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2300)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 20 && years <= 29)
                    {
                        if (res < 1500)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1500 && res < 1800)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1800 && res < 2200)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2200 && res < 2700)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2700)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 30 && years <= 39)
                    {
                        if (res < 1400)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1400 && res < 1700)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1700 && res < 2000)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 2000 && res < 2500)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2500)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years >= 40 && years <= 49)
                    {
                        if (res < 1200)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1200 && res < 1500)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1500 && res < 1900)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 1900 && res < 2300)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2300)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                    if (years > 50)
                    {
                        if (res < 1100)
                            ChangeLableColorNText("Очень слабая", ref Kuper_R, Color.DarkRed);
                        if (res >= 1100 && res < 1400)
                            ChangeLableColorNText("Слабая", ref Kuper_R, Color.Red);
                        if (res >= 1400 && res < 1700)
                            ChangeLableColorNText("Удовлетворительная", ref Kuper_R, Color.OrangeRed);
                        if (res >= 1700 && res < 2200)
                            ChangeLableColorNText("Хорошая", ref Kuper_R, Color.DarkGreen);
                        if (res >= 2200)
                            ChangeLableColorNText("Отличная", ref Kuper_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Prised()
        {
            try
            {
                int one_min = int.Parse(Pulse_1m.Text);
                int relax = int.Parse(Pulse_Stil.Text);
                int two_min = int.Parse(Pulse_2m.Text);
                int three_min = int.Parse(Pulse_3m.Text);
                double res = double.Parse(Pulse_20sit.Text);

                if (additional_Data_list.Count > 1)
                {
                    double res2 = double.Parse(additional_Data_list[1].Pulse_20squats) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result <= 0)
                        ChangeLableColorNText("+" + (-result).ToString() + "%", ref Pulse_Delta, Color.Green);
                    else
                        ChangeLableColorNText("-" + (-result).ToString() + "%", ref Pulse_Delta, Color.Red);
                }

                if (one_min <= relax + 5)
                    ChangeLableColorNText("Отличная приспособляемость", ref Pulse_R, Color.Green);
                else if (two_min <= relax + 5)
                    ChangeLableColorNText("Хорошая приспособляемость", ref Pulse_R, Color.DarkGreen);
                else if (three_min <= relax + 5)
                    ChangeLableColorNText("Удовлетворительная приспособляемость", ref Pulse_R, Color.OrangeRed);
                else
                    ChangeLableColorNText("Плохая приспособляемость", ref Pulse_R, Color.Red);
            }
            catch { }
            
        }
        void Step()
        {
            try
            {
                int height = int.Parse(user_Sport_Data.Height);
                if (height <= 152)
                    Step_Sk.Text = "30 см";
                if (height > 152 && height <= 160)
                    Step_Sk.Text = "35 см";
                if (height > 160 && height <= 175)
                    Step_Sk.Text = "40 см";
                if (height > 175 && height <= 180)
                    Step_Sk.Text = "45 см";
                if (height > 180)
                    Step_Sk.Text = "50 см";

                int years = int.Parse(user_Sport_Data.Years);
                double res = 24000.0 / ((double.Parse(Step_Pulse.Text) + double.Parse(Step_Pulse2.Text) + double.Parse(Step_Pulse3.Text)) * 2);

                if (additional_Data_list.Count > 1)
                {
                    double res2 = 24000.0 / ((double.Parse(additional_Data_list[1].Step_pulse) + double.Parse(additional_Data_list[1].Step_pulse_2m) + double.Parse(additional_Data_list[1].Step_pulse_3m)) * 2) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Step_D, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Step_D, Color.Red);
                }

                Step_D.Text = res.ToString();

                if (years <= 40)
                {
                    if (res <= 60)
                        ChangeLableColorNText("Плохая работоспособность", ref Step_R, Color.Red);
                    if (res > 60 && res <= 76)
                        ChangeLableColorNText("Удовлетворительная работоспособность", ref Step_R, Color.OrangeRed);
                    if (res >= 77 && res <= 85)
                        ChangeLableColorNText("Хорошая работоспособность", ref Step_R, Color.DarkGreen);
                    if (res >= 86)
                        ChangeLableColorNText("Отличная работоспособность", ref Step_R, Color.Green);
                }
                else
                {
                    if (res <= 50)
                        ChangeLableColorNText("Плохая работоспособность", ref Step_R, Color.Red);
                    if (res > 50 && res <= 70)
                        ChangeLableColorNText("Удовлетворительная работоспособность", ref Step_R, Color.OrangeRed);
                    if (res >= 71 && res <= 85)
                        ChangeLableColorNText("Хорошая работоспособность", ref Step_R, Color.DarkGreen);
                    if (res >= 86)
                        ChangeLableColorNText("Отличная работоспособность", ref Step_R, Color.Green);
                }
            }
            catch { }
        }
        void Shtange()
        {
            try
            {
                double res = double.Parse(Shtange_D.Text);

                if (additional_Data_list.Count > 1)
                {
                    double res2 = double.Parse(additional_Data_list[1].Stange) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Shtange_Delta, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Shtange_Delta, Color.Red);
                }

                if (res >= 50)
                    ChangeLableColorNText("Отлично", ref Shtange_R, Color.Green);
                if (res >= 40 && res < 50)
                    ChangeLableColorNText("Хорошо", ref Shtange_R, Color.OrangeRed);
                if (res < 40)
                    ChangeLableColorNText("Плохо", ref Shtange_R, Color.Red);
            }
            catch { }
            try
            {
                double res = double.Parse(Genchi_D.Text);
                if (additional_Data_list.Count > 1)
                {
                    double res2 = double.Parse(additional_Data_list[1].Ghenci) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Genchi_Delta, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Genchi_Delta, Color.Red);
                }
                if (res >= 40)
                    ChangeLableColorNText("Отлично", ref Genchi_R, Color.Green);
                if (res >= 35 && res < 40)
                    ChangeLableColorNText("Хорошо", ref Genchi_R, Color.OrangeRed);
                if (res < 35)
                    ChangeLableColorNText("Плохо", ref Genchi_R, Color.Red);
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
                if (additional_Data != null)
                {
                    Kuper_D.Text = additional_Data.Kuper;
                    Kuper();
                    Pulse_Stil.Text = additional_Data.Stil_pulse;
                    Pulse_20sit.Text = additional_Data.Pulse_20squats;
                    Pulse_1m.Text = additional_Data.Pulse_1min;
                    Pulse_2m.Text = additional_Data.Pulse_2min;
                    Pulse_3m.Text = additional_Data.Pulse_3min;
                    Prised();
                    Step_Pulse.Text = additional_Data.Step_pulse;
                    Step_Pulse2.Text = additional_Data.Step_pulse_2m;
                    Step_Pulse3.Text = additional_Data.Step_pulse_3m;
                    Step();
                    Shtange_D.Text = additional_Data.Stange;
                    Genchi_D.Text = additional_Data.Ghenci;
                    Shtange();
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
                SDS_user_additional_data add = new SDS_user_additional_data();
                Client = new SDS_serviceClient();
                Client.Open();
                add.Login = login;
                DateTime time = DateTime.Now;
                add.Date = time.Year.ToString() + "." + time.Month.ToString() + "." +
                    time.Day.ToString() + "." + time.Hour.ToString() + "." + time.Minute.ToString() + "." + time.Second.ToString();
                add.Kuper = Kuper_D.Text;
                add.Stil_pulse = Pulse_Stil.Text;
                add.Pulse_20squats = Pulse_20sit.Text;
                add.Pulse_1min = Pulse_1m.Text;
                add.Pulse_2min = Pulse_2m.Text;
                add.Pulse_3min = Pulse_3m.Text;
                add.Step_pulse = Step_Pulse.Text;
                add.Step_pulse_2m = Step_Pulse2.Text;
                add.Step_pulse_3m = Step_Pulse3.Text;
                add.Stange = Shtange_D.Text;
                add.Ghenci = Genchi_D.Text;
                if (!Client.ChangeAdditionalData(add))
                    throw new Exception();
                Good.Text = "Данные успешно обновлены";
                Good.ForeColor = Color.Green;
                Client.Close();
            }
            catch
            {
                Good.Text = "Во время сохранения произошла ошибка, попробуйте позже";
                Good.ForeColor = Color.Red;
            }
        }
    }
}