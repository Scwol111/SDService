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
    public partial class Crepost : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Crepost(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        private void Crepost_Load(object sender, EventArgs e)
        {
            if (data.Full())
            {
                int temp;
                temp = data.Height - (data.Weight + data.Chest_girh);
                label4.Text = Convert.ToString(temp);
                if (temp <= 15)
                {
                    label5.Text = "Крепкое телосложение";
                    label5.ForeColor = Color.DarkGreen;
                }
                if (temp >= 16 && temp <= 20)
                {
                    label5.Text = "Хорошее телосложение";
                    label5.ForeColor = Color.Green;
                }
                if (temp >= 21 && temp <= 25)
                {
                    label5.Text = "Среднее телосложение";
                    label5.ForeColor = Color.Orange;
                }
                if (temp >= 26 && temp <= 30)
                {
                    label5.Text = "Слабое телосложение";
                    label5.ForeColor = Color.OrangeRed;
                }
                if (temp >= 31)
                {
                    label5.Text = "Очень слабое телосложение";
                    label5.ForeColor = Color.Red;
                }
            }
            else
                label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Crepost_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
