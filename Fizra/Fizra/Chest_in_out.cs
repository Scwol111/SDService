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
    public partial class Chest_in_out : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        public Chest_in_out(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Chest_in_out_Load(object sender, EventArgs e)
        {
            if (data.Full())
            {
                int exc;
                exc = data.Chest_girh_in - data.Chest_girh_out;
                label4.Text = Convert.ToString(exc);
                if (exc < 5)
                {
                    label5.Text = "Низкое развитие";
                    label5.ForeColor = Color.Red;
                }
                if (exc > 4 && exc < 10)
                {
                    label5.Text = "Среднее развитие";
                    label5.ForeColor = Color.Orange;
                }
                if (exc > 9)
                {
                    label5.Text = "Высокое развитие";
                    label5.ForeColor = Color.Green;
                }
            }
            else
                label1.Visible = true;
        }

        private void Chest_in_out_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
