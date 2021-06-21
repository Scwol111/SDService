using System;
using System.Drawing;
using SDS_LIB;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDS_webapp
{
    public partial class Normes : SDS_page
    {
        void ChangeLableColorNText(string text, ref Label lb, Color color)
        {
            lb.Text = text;
            lb.ForeColor = color;
        }
        void Run()
        {
            try
            {
                double res = double.Parse(Run_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Run_100m) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta0, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta0, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res > 18)
                            ChangeLableColorNText("Не удовлетворительно", ref Run_R, Color.Red);
                        if (res <= 18 && res > 17)
                            ChangeLableColorNText("Удовлетворительно", ref Run_R, Color.OrangeRed);
                        if (res <= 17 && res > 16.5)
                            ChangeLableColorNText("Хорошо", ref Run_R, Color.DarkGreen);
                        if (res <= 16.5)
                            ChangeLableColorNText("Отлично", ref Run_R, Color.Green);
                    }
                    else
                    {
                        if (res > 15.5)
                            ChangeLableColorNText("Не удовлетворительно", ref Run_R, Color.Red);
                        if (res <= 15.5 && res > 14.8)
                            ChangeLableColorNText("Удовлетворительно", ref Run_R, Color.OrangeRed);
                        if (res <= 14.8 && res > 13.5)
                            ChangeLableColorNText("Хорошо", ref Run_R, Color.DarkGreen);
                        if (res <= 13.5)
                            ChangeLableColorNText("Отлично", ref Run_R, Color.Green);
                    }
                }
                else
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res > 22)
                            ChangeLableColorNText("Не удовлетворительно", ref Run_R, Color.Red);
                        if (res <= 22 && res > 20)
                            ChangeLableColorNText("Удовлетворительно", ref Run_R, Color.OrangeRed);
                        if (res <= 20 && res > 18)
                            ChangeLableColorNText("Хорошо", ref Run_R, Color.DarkGreen);
                        if (res <= 18)
                            ChangeLableColorNText("Отлично", ref Run_R, Color.Green);
                    }
                    else
                    {
                        if (res > 18)
                            ChangeLableColorNText("Не удовлетворительно", ref Run_R, Color.Red);
                        if (res <= 18 && res > 17)
                            ChangeLableColorNText("Удовлетворительно", ref Run_R, Color.OrangeRed);
                        if (res <= 17 && res > 16.5)
                            ChangeLableColorNText("Хорошо", ref Run_R, Color.DarkGreen);
                        if (res <= 16.5)
                            ChangeLableColorNText("Отлично", ref Run_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Cross()
        {
            try
            {
                double res = double.Parse(Cross_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Cross) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta1, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta1, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res > 15.3)
                            ChangeLableColorNText("Удовлетворительно", ref Cross_R, Color.OrangeRed);
                        if (res <= 15.3 && res > 14)
                            ChangeLableColorNText("Хорошо", ref Cross_R, Color.DarkGreen);
                        if (res < 14)
                            ChangeLableColorNText("Отлично", ref Cross_R, Color.Green);
                    }
                    else
                    {
                        if (res > 15)
                            ChangeLableColorNText("Не удовлетворительно", ref Cross_R, Color.Red);
                        if (res <= 15 && res > 13.3)
                            ChangeLableColorNText("Удовлетворительно", ref Cross_R, Color.OrangeRed);
                        if (res <= 13.3 && res > 12.3)
                            ChangeLableColorNText("Хорошо", ref Cross_R, Color.DarkGreen);
                        if (res < 12.3)
                            ChangeLableColorNText("Отлично", ref Cross_R, Color.Green);
                    }
                }
                else
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                        Cross_L.Text = "Бег 1000м(мин, сек)";
                    else
                        Cross_L.Text = "Бег 2000м(мин, сек)";
                    if (res > 11.15)
                        ChangeLableColorNText("Удовлетворительно", ref Cross_R, Color.OrangeRed);
                    if (res <= 11.15 && res > 10.3)
                        ChangeLableColorNText("Хорошо", ref Cross_R, Color.DarkGreen);
                    if (res < 10.3)
                        ChangeLableColorNText("Отлично", ref Cross_R, Color.Green);
                }
            }
            catch { }
        }
        void Podt()
        {
            try
            {
                double res = double.Parse(Push_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Pull_up) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta2, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta2, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 1)
                            ChangeLableColorNText("Не удовлетворительно", ref Push_R, Color.Red);
                        if (res >= 1 && res < 5)
                            ChangeLableColorNText("Удовлетворительно", ref Push_R, Color.OrangeRed);
                        if (res >= 5 && res < 10)
                            ChangeLableColorNText("Хорошо", ref Push_R, Color.DarkGreen);
                        if (res >= 10)
                            ChangeLableColorNText("Отлично", ref Push_R, Color.Green);
                    }
                    else
                    {
                        if (res < 6)
                            ChangeLableColorNText("Не удовлетворительно", ref Push_R, Color.Red);
                        if (res >= 6 && res < 10)
                            ChangeLableColorNText("Удовлетворительно", ref Push_R, Color.OrangeRed);
                        if (res >= 10 && res < 13)
                            ChangeLableColorNText("Хорошо", ref Push_R, Color.DarkGreen);
                        if (res >= 13)
                            ChangeLableColorNText("Отлично", ref Push_R, Color.Green);
                    }
                }
                else
                {
                    Push_L.Text = "Подтягивания из виса на низкой перекладине";
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 7)
                            ChangeLableColorNText("Не удовлетворительно", ref Push_R, Color.Red);
                        if (res >= 7 && res < 10)
                            ChangeLableColorNText("Удовлетворительно", ref Push_R, Color.OrangeRed);
                        if (res >= 10 && res < 15)
                            ChangeLableColorNText("Хорошо", ref Push_R, Color.DarkGreen);
                        if (res >= 15)
                            ChangeLableColorNText("Отлично", ref Push_R, Color.Green);
                    }
                    else
                    {
                        if (res < 8)
                            ChangeLableColorNText("Не удовлетворительно", ref Push_R, Color.Red);
                        if (res >= 8 && res < 15)
                            ChangeLableColorNText("Удовлетворительно", ref Push_R, Color.OrangeRed);
                        if (res >= 15 && res < 20)
                            ChangeLableColorNText("Хорошо", ref Push_R, Color.DarkGreen);
                        if (res >= 20)
                            ChangeLableColorNText("Отлично", ref Push_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Otz()
        {
            try
            {
                double res = double.Parse(Otz_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Push_ups) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta3, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta3, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 22)
                            ChangeLableColorNText("Не удовлетворительно", ref Otz_R, Color.Red);
                        if (res >= 22 && res < 25)
                            ChangeLableColorNText("Удовлетворительно", ref Otz_R, Color.OrangeRed);
                        if (res >= 25 && res < 39)
                            ChangeLableColorNText("Хорошо", ref Otz_R, Color.DarkGreen);
                        if (res >= 39)
                            ChangeLableColorNText("Отлично", ref Otz_R, Color.Green);
                    }
                    else
                    {
                        if (res < 28)
                            ChangeLableColorNText("Не удовлетворительно", ref Otz_R, Color.Red);
                        if (res >= 28 && res < 32)
                            ChangeLableColorNText("Удовлетворительно", ref Otz_R, Color.OrangeRed);
                        if (res >= 32 && res < 44)
                            ChangeLableColorNText("Хорошо", ref Otz_R, Color.DarkGreen);
                        if (res >= 44)
                            ChangeLableColorNText("Отлично", ref Otz_R, Color.Green);
                    }
                }
                else
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 3)
                            ChangeLableColorNText("Не удовлетворительно", ref Otz_R, Color.Red);
                        if (res >= 3 && res < 5)
                            ChangeLableColorNText("Удовлетворительно", ref Otz_R, Color.OrangeRed);
                        if (res >= 5 && res < 10)
                            ChangeLableColorNText("Хорошо", ref Otz_R, Color.DarkGreen);
                        if (res >= 10)
                            ChangeLableColorNText("Отлично", ref Otz_R, Color.Green);
                    }
                    else
                    {
                        if (res < 5)
                            ChangeLableColorNText("Не удовлетворительно", ref Run_R, Color.Red);
                        if (res >= 5 && res < 12)
                            ChangeLableColorNText("Удовлетворительно", ref Run_R, Color.OrangeRed);
                        if (res >= 12 && res < 16)
                            ChangeLableColorNText("Хорошо", ref Run_R, Color.DarkGreen);
                        if (res >= 16)
                            ChangeLableColorNText("Отлично", ref Run_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Nakl()
        {
            try
            {
                double res = double.Parse(NaK_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Forward_bend) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta4, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta4, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 1)
                            ChangeLableColorNText("Не удовлетворительно", ref Nak_R, Color.Red);
                        if (res >= 1 && res < 5)
                            ChangeLableColorNText("Удовлетворительно", ref Nak_R, Color.OrangeRed);
                        if (res >= 5 && res < 7)
                            ChangeLableColorNText("Хорошо", ref Nak_R, Color.DarkGreen);
                        if (res >= 7)
                            ChangeLableColorNText("Отлично", ref Nak_R, Color.Green);
                    }
                    else
                    {
                        if (res < 5)
                            ChangeLableColorNText("Не удовлетворительно", ref Nak_R, Color.Red);
                        if (res >= 5 && res < 7)
                            ChangeLableColorNText("Удовлетворительно", ref Nak_R, Color.OrangeRed);
                        if (res >= 7 && res < 13)
                            ChangeLableColorNText("Хорошо", ref Nak_R, Color.DarkGreen);
                        if (res >= 13)
                            ChangeLableColorNText("Отлично", ref Nak_R, Color.Green);
                    }
                }
                else
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 5)
                            ChangeLableColorNText("Не удовлетворительно", ref Nak_R, Color.Red);
                        if (res >= 5 && res < 7)
                            ChangeLableColorNText("Удовлетворительно", ref Nak_R, Color.OrangeRed);
                        if (res >= 7 && res < 10)
                            ChangeLableColorNText("Хорошо", ref Nak_R, Color.DarkGreen);
                        if (res >= 10)
                            ChangeLableColorNText("Отлично", ref Nak_R, Color.Green);
                    }
                    else
                    {
                        if (res < 5)
                            ChangeLableColorNText("Не удовлетворительно", ref Nak_R, Color.Red);
                        if (res >= 5 && res < 11)
                            ChangeLableColorNText("Удовлетворительно", ref Nak_R, Color.OrangeRed);
                        if (res >= 11 && res < 16)
                            ChangeLableColorNText("Хорошо", ref Nak_R, Color.DarkGreen);
                        if (res >= 16)
                            ChangeLableColorNText("Отлично", ref Nak_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Jump()
        {
            try
            {
                double res = double.Parse(Jump_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Jump) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta5, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta5, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 170)
                            ChangeLableColorNText("Не удовлетворительно", ref Jump_R, Color.Red);
                        if (res >= 170 && res < 190)
                            ChangeLableColorNText("Удовлетворительно", ref Jump_R, Color.OrangeRed);
                        if (res >= 190 && res < 200)
                            ChangeLableColorNText("Хорошо", ref Jump_R, Color.DarkGreen);
                        if (res >= 200)
                            ChangeLableColorNText("Отлично", ref Jump_R, Color.Green);
                    }
                    else
                    {
                        if (res < 200)
                            ChangeLableColorNText("Не удовлетворительно", ref Jump_R, Color.Red);
                        if (res >= 200 && res < 230)
                            ChangeLableColorNText("Удовлетворительно", ref Jump_R, Color.OrangeRed);
                        if (res >= 230 && res < 240)
                            ChangeLableColorNText("Хорошо", ref Jump_R, Color.DarkGreen);
                        if (res >= 240)
                            ChangeLableColorNText("Отлично", ref Jump_R, Color.Green);
                    }
                }
                else
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 110)
                            ChangeLableColorNText("Не удовлетворительно", ref Jump_R, Color.Red);
                        if (res >= 110 && res < 135)
                            ChangeLableColorNText("Удовлетворительно", ref Jump_R, Color.OrangeRed);
                        if (res >= 135 && res < 165)
                            ChangeLableColorNText("Хорошо", ref Jump_R, Color.DarkGreen);
                        if (res >= 165)
                            ChangeLableColorNText("Отлично", ref Jump_R, Color.Green);
                    }
                    else
                    {
                        if (res < 150)
                            ChangeLableColorNText("Не удовлетворительно", ref Jump_R, Color.Red);
                        if (res >= 150 && res < 180)
                            ChangeLableColorNText("Удовлетворительно", ref Jump_R, Color.OrangeRed);
                        if (res >= 180 && res < 195)
                            ChangeLableColorNText("Хорошо", ref Jump_R, Color.DarkGreen);
                        if (res >= 195)
                            ChangeLableColorNText("Отлично", ref Jump_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Press()
        {
            try
            {
                double res = double.Parse(Press_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Press) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta6, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta6, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 30)
                            ChangeLableColorNText("Не удовлетворительно", ref Press_R, Color.Red);
                        if (res >= 30 && res < 35)
                            ChangeLableColorNText("Удовлетворительно", ref Press_R, Color.OrangeRed);
                        if (res >= 35 && res < 45)
                            ChangeLableColorNText("Хорошо", ref Press_R, Color.DarkGreen);
                        if (res >= 45)
                            ChangeLableColorNText("Отлично", ref Press_R, Color.Green);
                    }
                    else
                    {
                        if (res < 33)
                            ChangeLableColorNText("Не удовлетворительно", ref Press_R, Color.Red);
                        if (res >= 33 && res < 37)
                            ChangeLableColorNText("Удовлетворительно", ref Press_R, Color.OrangeRed);
                        if (res >= 37 && res < 48)
                            ChangeLableColorNText("Хорошо", ref Press_R, Color.DarkGreen);
                        if (res >= 48)
                            ChangeLableColorNText("Отлично", ref Press_R, Color.Green);
                    }
                }
                else
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 15)
                            ChangeLableColorNText("Не удовлетворительно", ref Press_R, Color.Red);
                        if (res >= 15 && res < 20)
                            ChangeLableColorNText("Удовлетворительно", ref Press_R, Color.OrangeRed);
                        if (res >= 20 && res < 30)
                            ChangeLableColorNText("Хорошо", ref Press_R, Color.DarkGreen);
                        if (res >= 30)
                            ChangeLableColorNText("Отлично", ref Press_R, Color.Green);
                    }
                    else
                    {
                        if (res < 25)
                            ChangeLableColorNText("Не удовлетворительно", ref Press_R, Color.Red);
                        if (res >= 25 && res < 40)
                            ChangeLableColorNText("Удовлетворительно", ref Press_R, Color.OrangeRed);
                        if (res >= 40 && res < 47)
                            ChangeLableColorNText("Хорошо", ref Press_R, Color.DarkGreen);
                        if (res >= 47)
                            ChangeLableColorNText("Отлично", ref Press_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Swimming()
        {
            try
            {
                double res = double.Parse(Swim_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Swimming) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta7, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta7, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res > 1.5)
                            ChangeLableColorNText("Удовлетворительно", ref Swim_R, Color.OrangeRed);
                        if (res <= 1.5 && res > 1.15)
                            ChangeLableColorNText("Хорошо", ref Swim_R, Color.DarkGreen);
                        if (res <= 1.15)
                            ChangeLableColorNText("Отлично", ref Swim_R, Color.Green);
                    }
                    else
                    {
                        if (res > 1)
                            ChangeLableColorNText("Удовлетворительно", ref Swim_R, Color.OrangeRed);
                        if (res <= 1 && res > 0.42)
                            ChangeLableColorNText("Хорошо", ref Swim_R, Color.DarkGreen);
                        if (res <= 0.42)
                            ChangeLableColorNText("Отлично", ref Swim_R, Color.Green);
                    }
                }
                else
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        ChangeLableColorNText("Хорошо", ref Swim_R, Color.DarkGreen);
                        if (res <= 1.5)
                            ChangeLableColorNText("Отлично", ref Swim_R, Color.Green);
                    }
                    else
                    {
                        if (res > 1.1)
                            ChangeLableColorNText("Хорошо", ref Swim_R, Color.DarkGreen);
                        if (res <= 1.1)
                            ChangeLableColorNText("Отлично", ref Swim_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Ski()
        {
            try
            {
                double res = double.Parse(Ski_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Ski) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta8, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta8, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 27)
                            ChangeLableColorNText("Удовлетворительно", ref Ski_R, Color.OrangeRed);
                        if (res <= 27 && res > 25.3)
                            ChangeLableColorNText("Хорошо", ref Ski_R, Color.DarkGreen);
                        if (res <= 25.3)
                            ChangeLableColorNText("Отлично", ref Ski_R, Color.Green);
                    }
                    else
                    {
                        if (res > 27)
                            ChangeLableColorNText("Не удовлетворительно", ref Ski_R, Color.Red);
                        if (res <= 27 && res > 25.3)
                            ChangeLableColorNText("Удовлетворительно", ref Ski_R, Color.OrangeRed);
                        if (res <= 25.3 && res > 23.3)
                            ChangeLableColorNText("Хорошо", ref Ski_R, Color.DarkGreen);
                        if (res <= 23.3)
                            ChangeLableColorNText("Отлично", ref Ski_R, Color.Green);
                    }
                }
                else
                {
                    Ski_L.Text = "Бег на лыжах 3 км (мин, сек)";
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res > 25)
                            ChangeLableColorNText("Удовлетворительно", ref Ski_R, Color.OrangeRed);
                        if (res <= 25 && res > 21)
                            ChangeLableColorNText("Хорошо", ref Ski_R, Color.DarkGreen);
                        if (res <= 21)
                            ChangeLableColorNText("Отлично", ref Ski_R, Color.Green);
                    }
                    else
                    {
                        if (res > 19.3)
                            ChangeLableColorNText("Удовлетворительно", ref Ski_R, Color.OrangeRed);
                        if (res <= 19.3 && res > 18)
                            ChangeLableColorNText("Хорошо", ref Ski_R, Color.DarkGreen);
                        if (res <= 18)
                            ChangeLableColorNText("Отлично", ref Ski_R, Color.Green);
                    }
                }
            }
            catch { }
        }
        void Gira()
        {
            try
            {
                double res = double.Parse(Gir_D.Text);

                if (user_Normes_list.Count > 1)
                {
                    double res2 = double.Parse(user_Normes_list[1].Kettlebell) / 100.0;
                    double result = res / res2 * 100 - 100;

                    if (result > 0)
                        ChangeLableColorNText("+" + result.ToString() + "%", ref Delta9, Color.Green);
                    else
                        ChangeLableColorNText(result.ToString() + "%", ref Delta9, Color.Red);
                }
                if (user_Sport_Data.Gender == "Мужской")
                {
                    if (user_Sport_Data.SpecialGroup == "YES")
                    {
                        if (res < 15)
                            ChangeLableColorNText("Не удовлетворительно", ref Gir_R, Color.Red);
                        if (res >= 15 && res < 18)
                            ChangeLableColorNText("Удовлетворительно", ref Gir_R, Color.OrangeRed);
                        if (res >= 18 && res < 33)
                            ChangeLableColorNText("Хорошо", ref Gir_R, Color.DarkGreen);
                        if (res >= 33)
                            ChangeLableColorNText("Отлично", ref Gir_R, Color.Green);
                    }
                    else
                    {
                        if (res < 15)
                            ChangeLableColorNText("Не удовлетворительно", ref Gir_R, Color.Red);
                        if (res >= 15 && res < 30)
                            ChangeLableColorNText("Удовлетворительно", ref Gir_R, Color.OrangeRed);
                        if (res >= 30 && res < 40)
                            ChangeLableColorNText("Хорошо", ref Gir_R, Color.DarkGreen);
                        if (res >= 40)
                            ChangeLableColorNText("Отлично", ref Gir_R, Color.Green);
                    }
                }
                else
                {
                    Gir_D.Visible = false;
                    Gir_L.Visible = false;
                    Gir_R.Visible = false;
                    Delta9.Visible = false;
                }
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
                if (user_Normes != null)
                {
                    Run_D.Text = user_Normes.Run_100m;
                    Run();
                    Cross_D.Text = user_Normes.Cross;
                    Cross();
                    Push_D.Text = user_Normes.Pull_up;
                    Podt();
                    Otz_D.Text = user_Normes.Push_ups;
                    Otz();
                    NaK_D.Text = user_Normes.Forward_bend;
                    Nakl();
                    Jump_D.Text = user_Normes.Jump;
                    Jump();
                    Press_D.Text = user_Normes.Press;
                    Press();
                    Swim_D.Text = user_Normes.Swimming;
                    Swimming();
                    Ski_D.Text = user_Normes.Ski;
                    Ski();
                    Gir_D.Text = user_Normes.Kettlebell;
                    Gira();
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
                SDS_user_normes normes = new SDS_user_normes();
                normes.Login = login;
                DateTime time = DateTime.Now;
                normes.Date = time.Year.ToString() + "." + time.Month.ToString() + "." +
                    time.Day.ToString() + "." + time.Hour.ToString() + "." + time.Minute.ToString() + "." + time.Second.ToString();
                normes.Run_100m = Run_D.Text;
                normes.Cross = Cross_D.Text;
                normes.Pull_up = Push_D.Text;
                normes.Push_ups = Otz_D.Text;
                normes.Forward_bend = NaK_D.Text;
                normes.Jump = Jump_D.Text;
                normes.Press = Press_D.Text;
                normes.Swimming = Swim_D.Text; 
                normes.Ski = Ski_D.Text;
                normes.Kettlebell = Gir_D.Text;
                if (!Client.ChangeNormesData(normes))
                    throw new Exception();
                Good.Text = "Данные успешно обновлены";
                Good.ForeColor = Color.Green;
            }
            catch
            {
                Good.Text = "Во время сохранения произошла ошибка, попробуйте позже";
                Good.ForeColor = Color.Red;
            }
        }
    }
}