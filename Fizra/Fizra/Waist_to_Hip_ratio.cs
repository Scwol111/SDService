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
    public partial class Waist_to_Hip_ratio : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Waist_to_Hip_ratio(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Waist_to_Hip_ratio_Load(object sender, EventArgs e)
        {
            if (data.Full())
            {
                float temp;
                temp = (float)data.Waist / (float)data.Thigh;
                label4.Text = Convert.ToString(temp);
                if (data.Gender == "Мужской")
                {
                    if (temp <= 0.9)
                    {
                        label5.Text = "В пределах нормы";
                        label5.ForeColor = Color.Green;
                    }
                    else
                    {
                        label5.Text = "Выше нормы";
                        label5.ForeColor = Color.Red;
                    }
                }
                else
                {
                    if (temp <= 0.8)
                    {
                        label5.Text = "В пределах нормы";
                        label5.ForeColor = Color.Green;
                    }
                    else
                    {
                        label5.Text = "Выше нормы";
                        label5.ForeColor = Color.Red;
                    }
                }
            }
            else
                label1.Visible = true;
        }

        private void Waist_to_Hip_ratio_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
