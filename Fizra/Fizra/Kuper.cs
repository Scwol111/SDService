using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizra
{
    public partial class Kuper : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Kuper(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
            if (!dt.Full())
            {
                label4.Visible = true;
                textBox1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Для определения выносливости методом Купера необходимо определить расстояние," +
                " которое вы можете преодолеть бегом (при утомлении разрешается переходить на ходьбу, чередовать" +
                " ходьбу с бегом). Пройденное расстояние в метрах необходимо записать в соответствующие поле," +
                " а затем нажать кнопку <Результат> для получения результата";
            if (richTextBox1.Visible)
                richTextBox1.Visible = false;
            else
                richTextBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Text = "Нет данных";
            label3.ForeColor = Color.Black;
        }
        bool Digit_string(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (!((str[i] >= '0' && str[i] <= '9') || str[i] == ' '))
                    return false;
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Kuper_result kuper = new Kuper_result();
            int res;
            if (textBox1.Text.Length > 0 && Digit_string(textBox1.Text))
            {
                res = int.Parse(textBox1.Text);
                if (data.Gender == "Мужской")
                {
                    if (data.Years <= 14)
                    {
                        if (res < 2100)
                            kuper.Set(0);
                        if (res >= 2100 && res < 2200)
                            kuper.Set(1);
                        if (res >= 2200 && res < 2400)
                            kuper.Set(2);
                        if (res >= 2400 && res < 2700)
                            kuper.Set(3);
                        if (res >= 2700)
                            kuper.Set(4);
                    }
                    if (data.Years >= 15 && data.Years <= 16)
                    {
                        if (res < 2200)
                            kuper.Set(0);
                        if (res >= 2200 && res < 2300)
                            kuper.Set(1);
                        if (res >= 2300 && res < 2500)
                            kuper.Set(2);
                        if (res >= 2500 && res < 2800)
                            kuper.Set(3);
                        if (res >= 2800)
                            kuper.Set(4);
                    }
                    if (data.Years >= 17 && data.Years <= 19)
                    {
                        if (res < 2300)
                            kuper.Set(0);
                        if (res >= 2300 && res < 2500)
                            kuper.Set(1);
                        if (res >= 2500 && res < 2700)
                            kuper.Set(2);
                        if (res >= 2700 && res < 3000)
                            kuper.Set(3);
                        if (res >= 3000)
                            kuper.Set(4);
                    }
                    if (data.Years >= 20 && data.Years <= 29)
                    {
                        if (res < 1600)
                            kuper.Set(0);
                        if (res >= 1600 && res < 2200)
                            kuper.Set(1);
                        if (res >= 2200 && res < 2400)
                            kuper.Set(2);
                        if (res >= 2400 && res < 2800)
                            kuper.Set(3);
                        if (res >= 2800)
                            kuper.Set(4);
                    }
                    if (data.Years >= 30 && data.Years <= 39)
                    {
                        if (res < 1500)
                            kuper.Set(0);
                        if (res >= 1500 && res < 1900)
                            kuper.Set(1);
                        if (res >= 1900 && res < 2300)
                            kuper.Set(2);
                        if (res >= 2300 && res < 2700)
                            kuper.Set(3);
                        if (res >= 2700)
                            kuper.Set(4);
                    }
                    if (data.Years >= 40 && data.Years <= 49)
                    {
                        if (res < 1400)
                            kuper.Set(0);
                        if (res >= 1400 && res < 1700)
                            kuper.Set(1);
                        if (res >= 1700 && res < 2100)
                            kuper.Set(2);
                        if (res >= 2100 && res < 2500)
                            kuper.Set(3);
                        if (res >= 2700)
                            kuper.Set(4);
                    }
                    if (data.Years > 50)
                    {
                        if (res < 1300)
                            kuper.Set(0);
                        if (res >= 1300 && res < 1600)
                            kuper.Set(1);
                        if (res >= 1600 && res < 2000)
                            kuper.Set(2);
                        if (res >= 2000 && res < 2400)
                            kuper.Set(3);
                        if (res >= 2400)
                            kuper.Set(4);
                    }

                }   
                else
                {
                    if (data.Years <= 14)
                    {
                        if (res < 1500)
                            kuper.Set(0);
                        if (res >= 1500 && res < 1600)
                            kuper.Set(1);
                        if (res >= 1600 && res < 1900)
                            kuper.Set(2);
                        if (res >= 1900 && res < 2000)
                            kuper.Set(3);
                        if (res >= 2000)
                            kuper.Set(4);
                    }
                    if (data.Years >= 15 && data.Years <= 16)
                    {
                        if (res < 1600)
                            kuper.Set(0);
                        if (res >= 1600 && res < 1700)
                            kuper.Set(1);
                        if (res >= 1700 && res < 2000)
                            kuper.Set(2);
                        if (res >= 2000 && res < 2100)
                            kuper.Set(3);
                        if (res >= 2100)
                            kuper.Set(4);
                    }
                    if (data.Years >= 17 && data.Years <= 19)
                    {
                        if (res < 1700)
                            kuper.Set(0);
                        if (res >= 1700 && res < 1800)
                            kuper.Set(1);
                        if (res >= 1800 && res < 2100)
                            kuper.Set(2);
                        if (res >= 2100 && res < 2300)
                            kuper.Set(3);
                        if (res >= 2300)
                            kuper.Set(4);
                    }
                    if (data.Years >= 20 && data.Years <= 29)
                    {
                        if (res < 1500)
                            kuper.Set(0);
                        if (res >= 1500 && res < 1800)
                            kuper.Set(1);
                        if (res >= 1800 && res < 2200)
                            kuper.Set(2);
                        if (res >= 2200 && res < 2700)
                            kuper.Set(3);
                        if (res >= 2700)
                            kuper.Set(4);
                    }
                    if (data.Years >= 30 && data.Years <= 39)
                    {
                        if (res < 1400)
                            kuper.Set(0);
                        if (res >= 1400 && res < 1700)
                            kuper.Set(1);
                        if (res >= 1700 && res < 2000)
                            kuper.Set(2);
                        if (res >= 2000 && res < 2500)
                            kuper.Set(3);
                        if (res >= 2500)
                            kuper.Set(4);
                    }
                    if (data.Years >= 40 && data.Years <= 49)
                    {
                        if (res < 1200)
                            kuper.Set(0);
                        if (res >= 1200 && res < 1500)
                            kuper.Set(1);
                        if (res >= 1500 && res < 1900)
                            kuper.Set(2);
                        if (res >= 1900 && res < 2300)
                            kuper.Set(3);
                        if (res >= 2300)
                            kuper.Set(4);
                    }
                    if (data.Years > 50)
                    {
                        if (res < 1100)
                            kuper.Set(0);
                        if (res >= 1100 && res < 1400)
                            kuper.Set(1);
                        if (res >= 1400 && res < 1700)
                            kuper.Set(2);
                        if (res >= 1700 && res < 2200)
                            kuper.Set(3);
                        if (res >= 2200)
                            kuper.Set(4);
                    }
                }
                label3.Text = kuper.GetString;
                label3.ForeColor = kuper.GetColor;
            }
            else
                label4.Visible = true;
        }
        class Kuper_result
        {
            Color color;
            string text;
            public Color GetColor
            {
                get { return color; }
            }
            public string GetString
            {
                get { return text; }
            }
            public void Set(int res)
            {
                switch(res)
                {
                    case 0:
                        color = Color.Red;
                        text = "Очень слабая";
                        break;
                    case 1:
                        color = Color.OrangeRed;
                        text = "Слабая";
                        break;
                    case 2:
                        color = Color.Orange;
                        text = "Удовлетворительная";
                        break;
                    case 3:
                        color = Color.ForestGreen;
                        text = "Хорошая";
                        break;
                    case 4:
                        color = Color.Green;
                        text = "Отличная";
                        break;
                }

            }
        }

        private void Kuper_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
