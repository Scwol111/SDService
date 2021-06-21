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
    public partial class Erisman : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Erisman(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        private void Erisman_Load(object sender, EventArgs e)
        {
            if (data.Full())
            {
                float temp;
                temp = data.Chest_girh - (float)data.Height / 2;
                label4.Text = Convert.ToString(temp);
                if (temp < 0)
                {
                    label5.Text = "Слабое развитие";
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    label5.Text = "Нормальное развитие";
                    label5.ForeColor = Color.Green;
                }
            }
            else
                label1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Erisman_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
