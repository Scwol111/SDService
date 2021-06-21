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
    public partial class Garvard : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Garvard(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
            if (!data.Full())
            {
                button2.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                label10.Visible = true;
            }
            else
            {
                if (data.Height <= 152)
                    label5.Text = "30 см";
                if (data.Height > 152 && data.Height <= 160)
                    label5.Text = "35 см";
                if (data.Height > 160 && data.Height <= 175)
                    label5.Text = "40 см";
                if (data.Height > 175 && data.Height <= 180)
                    label5.Text = "45 см";
                if (data.Height > 180)
                    label5.Text = "50 см";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Тест заключается в повторных подъемах на ступеньку и спусках с них в течении 4 мин" +
                " Частота восхождения - 30 подъемов в 1 минуту под удары метронома. Подъем на ступеньки и опускание" +
                " на пол производится с одной и той же ноги на ступеньке, положение на ступеньке вертикальное с" +
                " выпрямленными ногами. После нагрузки подсчитывается пульс сидя за первые 30 сек на начало 2-ой и 3-ей " +
                "минуты отдыха. Затем полученные данные заносятся в соответствующие поля. Результат определяется при нажатии" +
                " кнопки <Результат>";
            if (richTextBox1.Visible)
                richTextBox1.Visible = false;
            else
                richTextBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
            int first = -1, second = -1, third = -1;
            float res;
            if (textBox1.TextLength > 0 && Digit_string(textBox1.Text))
                first = int.Parse(textBox1.Text);
            if (textBox2.TextLength > 0 && Digit_string(textBox2.Text))
                second = int.Parse(textBox2.Text);
            if (textBox3.TextLength > 0 && Digit_string(textBox3.Text))
                third = int.Parse(textBox3.Text);
            if (first > 0 && first < 500 && second > 0 && second < 500 && third > 0 && third < 500)
            {
                res = 24000 / ((first + second + third) * 2);
                label7.Text = Convert.ToString(res);
                if (data.Years <= 40)
                {
                    if (res <= 60)
                    {
                        label9.Text = "Плохая";
                        label9.ForeColor = Color.Red;
                    }
                    if (res > 60 && res <= 76)
                    {
                        label9.Text = "Средняя";
                        label9.ForeColor = Color.OrangeRed;
                    }
                    if (res >= 77 && res <= 85)
                    {
                        label9.Text = "Хорошая";
                        label9.ForeColor = Color.ForestGreen;
                    }
                    if (res >= 86)
                    {
                        label9.Text = "Отличная";
                        label9.ForeColor = Color.Green;
                    }
                }
                else
                {
                    if (res <= 50)
                    {
                        label9.Text = "Плохая";
                        label9.ForeColor = Color.Red;
                    }
                    if (res > 50 && res <= 70)
                    {
                        label9.Text = "Средняя";
                        label9.ForeColor = Color.OrangeRed;
                    }
                    if (res >= 71 && res <= 85)
                    {
                        label9.Text = "Хорошая";
                        label9.ForeColor = Color.ForestGreen;
                    }
                    if (res >= 86)
                    {
                        label9.Text = "Отличная";
                        label9.ForeColor = Color.Green;
                    }
                }
            }
            else
                label10.Visible = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label9.Text = "Нет данных";
            label9.ForeColor = Color.Black;
            label7.Text = "Нет данных";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label9.Text = "Нет данных";
            label9.ForeColor = Color.Black;
            label7.Text = "Нет данных";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label9.Text = "Нет данных";
            label9.ForeColor = Color.Black;
            label7.Text = "Нет данных";
        }

        private void Garvard_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
