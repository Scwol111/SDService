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
    public partial class Prised : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Prised(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Для определения функциональных возможностей организма замерьте ваш пульс в покое," +
                " затем сделайте 20 приседаний за 30 секунд. Замерить пульс после приседаний и по истечению 1, 2 и 3-х минут." +
                " Полученные данные записать в соответствующие колонки и нажать кнопку <Результат> для получения результата пробы";
            if (richTextBox1.Visible)
                richTextBox1.Visible = false;
            else
                richTextBox1.Visible = true;
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
            label7.Text = "Нет данных";
            richTextBox1.Visible = false;
            label7.ForeColor = Color.Black;
            int relax = -1, prised = -1;
            int one_min = -1, two_min = -1, three_min = -1;
            if (textBox1.Text.Length > 0 && Digit_string(textBox1.Text))
                relax = int.Parse(textBox1.Text);
            if (textBox2.Text.Length > 0 && Digit_string(textBox2.Text))
                prised = int.Parse(textBox2.Text);
            if (textBox3.Text.Length > 0 && Digit_string(textBox3.Text))
                one_min = int.Parse(textBox3.Text);
            if (textBox4.Text.Length > 0 && Digit_string(textBox4.Text))
                two_min = int.Parse(textBox4.Text);
            if (textBox5.Text.Length > 0 && Digit_string(textBox5.Text))
                three_min = int.Parse(textBox5.Text);
            if (relax > 0 && relax < 400 && prised > 0 && prised < 400 && one_min > 0 && one_min < 400 &&
                two_min > 0 && two_min < 400 && three_min > 0 && three_min < 400)
            {
                if (one_min <= relax + 5)
                {
                    label7.Text = "Отличная приспособляемость";
                    label7.ForeColor = Color.Green;
                }
                else if (two_min <= relax + 5)
                {
                    label7.Text = "Хорошая приспособляемость";
                    label7.ForeColor = Color.DarkGreen;
                }
                else if (three_min <= relax + 5)
                {
                    label7.Text = "Удовлетворительная приспособляемость";
                    label7.ForeColor = Color.OrangeRed;
                }
                else
                {
                    label7.Text = "Плохая приспособляемость";
                    label7.ForeColor = Color.Red;
                }
            }
            else
                label8.Visible = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;
            label7.Text = "Нет данных";
            label7.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;
            label7.Text = "Нет данных";
            label7.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;
            label7.Text = "Нет данных";
            label7.ForeColor = Color.Black;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;
            label7.Text = "Нет данных";
            label7.ForeColor = Color.Black;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;
            label7.Text = "Нет данных";
            label7.ForeColor = Color.Black;
        }

        private void Prised_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
