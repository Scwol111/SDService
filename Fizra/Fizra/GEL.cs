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
    public partial class GEL : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public GEL(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        private void GEL_Load(object sender, EventArgs e)
        {
            if (data.Full())
            {
                int temp;
                if (data.Gender == "Мужской")
                {
                    temp = 40 * data.Height + 30 * data.Weight - 4400;
                    label4.Text = Convert.ToString(temp);
                    label5.Text = Convert.ToString((float)temp / (float)data.Weight);
                }
                else
                {
                    temp = 40 * data.Height + 10 * data.Weight - 3800;
                    label4.Text = Convert.ToString(temp);
                    label5.Text = Convert.ToString((float)temp / (float)data.Weight);
                }
            }
            else
                label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GEL_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
