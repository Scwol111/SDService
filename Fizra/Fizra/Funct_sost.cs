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
    public partial class Funct_sost : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Funct_sost(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        private void Funct_sost_Load(object sender, EventArgs e)
        {
            if (data.Full())
            {
                double temp;
                temp = (double)(220 - data.Years);
                label4.Text = Convert.ToString((int)(temp * 0.5));
                label5.Text = Convert.ToString((int)(temp * 0.75));
            }
            else
                label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Funct_sost_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
