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
    public partial class Input : Form
    {
        Data data;
        public delegate void Del(Data a);
        public delegate void Del1();
        Del fun;
        Del1 form1;
        public Input(Del a, Data dt, Del1 b)
        {
            fun = a;
            data = new Data();
            form1 = b;
            InitializeComponent();
            if (dt.Full())
            {
                data = dt;
                textBox1.Text = Convert.ToString(data.Height);
                textBox2.Text = Convert.ToString(data.Weight);
                textBox3.Text = Convert.ToString(data.Chest_girh);
                textBox4.Text = Convert.ToString(data.Chest_girh_in);
                textBox5.Text = Convert.ToString(data.Chest_girh_out);
                textBox6.Text = Convert.ToString(data.Waist);
                textBox7.Text = Convert.ToString(data.Thigh);
                textBox8.Text = Convert.ToString(data.Years);
                if (data.Gender == "Мужской")
                    listBox1.SelectedIndex = 0;
                else
                    listBox1.SelectedIndex = 1;
            }

        }
        bool Digit_string(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (!((str[i] >= '0' && str[i] <= '9') || str[i] == ' '))
                    return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)//save
        {
            bool fl = false;
            if (textBox1.Text.Length > 0)//height
            {
                int temp = 0;
                data.Height = -1;
                if (Digit_string(textBox1.Text))
                    temp = int.Parse(textBox1.Text);
                if (temp > 0 && temp < 300)
                    data.Height = temp;
                else
                    fl = false;
            }
            if (textBox2.Text.Length > 0)//weight
            {
                int temp = 0;
                data.Weight = -1;
                if (Digit_string(textBox2.Text))
                    temp = int.Parse(textBox2.Text);
                if (temp > 0 && temp < 1000)
                    data.Weight = temp;
                else
                    fl = false;
            }
            if (textBox3.Text.Length > 0)//Chest_girh
            {
                int temp = 0;
                data.Chest_girh = -1;
                if (Digit_string(textBox3.Text))
                    temp = int.Parse(textBox3.Text);
                if (temp > 0 && temp < 300)
                    data.Chest_girh = temp;
                else
                    fl = false;
            }
            if (textBox4.Text.Length > 0)//Chest_girh_in
            {
                int temp = 0;
                data.Chest_girh_in = -1;
                if (Digit_string(textBox4.Text))
                    temp = int.Parse(textBox4.Text);
                if (temp > 0 && temp < 500)
                    data.Chest_girh_in = temp;
                else
                    fl = false;
            }
            if (textBox5.Text.Length > 0)//Chest_girh_out
            {
                int temp = 0;
                data.Chest_girh_out = -1;
                if (Digit_string(textBox5.Text))
                    temp = int.Parse(textBox5.Text);
                if (temp > 0 && temp < 300)
                    data.Chest_girh_out = temp;
                else
                    fl = false;
            }
            if (textBox6.Text.Length > 0)//waist
            {
                int temp = 0;
                data.Waist = -1;
                if (Digit_string(textBox6.Text))
                    temp = int.Parse(textBox6.Text);
                if (temp > 0 && temp < 300)
                    data.Waist = temp;
                else
                    fl = false;
            }
            if (textBox7.Text.Length > 0)//thigh
            {
                int temp = 0;
                data.Thigh = -1;
                if (Digit_string(textBox7.Text))
                    temp = int.Parse(textBox7.Text);
                if (temp > 0 && temp < 500)
                    data.Thigh = temp;
                else
                    fl = false;
            }
            if (textBox8.Text.Length > 0)//years
            {
                int temp = 0;
                data.Years = -1;
                if (Digit_string(textBox8.Text))
                    temp = int.Parse(textBox8.Text);
                if (temp > 0 && temp < 300)
                    data.Years = temp;
                else
                    fl = false;
            }
            if (listBox1.SelectedIndex > -1)//gender
                data.Gender = listBox1.GetItemText(listBox1.SelectedItem);
            if (checkBox1.Checked)
                data.Special = true;
            if (data.Full())
                fl = true;
            if (!fl)
                label10.Visible = true;
            else
                label11.Visible = true;
        }

        private void Input_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (data.Full())
                fun(data);
        }

        private void button2_Click(object sender, EventArgs e)//close
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
        }

        private void Input_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1();
        }
    }
}
