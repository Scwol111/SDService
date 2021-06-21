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
    public partial class BMI : Form
    {
        Data data;
        bool fl;
        public delegate void Del();
        Del del;
        public BMI(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
        }

        string Get_result(float temp)
        {
            if (temp < 20)
                return "Недостаток веса";
            if (temp >= 20 && temp <= 25)
                return "Нормальный вес";
            if (temp > 25 && temp <= 30)
                return "Избыточная масса";
            if (temp > 30 && temp <= 40)
                return "Ожирение";
            return "Сильное ожирение";
        }

        Color Get_color(float temp)
        {
            if (temp < 20)
                return Color.IndianRed;
            if (temp >= 20 && temp <= 25)
                return Color.Green;
            if (temp > 25 && temp <= 30)
                return Color.Orange;
            if (temp > 30 && temp <= 40)
                return Color.OrangeRed;
            return Color.DarkRed;
        }

        private void BMI_Load(object sender, EventArgs e)
        {
            if (!data.Full())
                fl = false;
            else
                fl = true;
            if (fl)
            {
                float temp;
                temp = (float)data.Weight / (float)(((float)data.Height / 100) * ((float)data.Height / 100));
                label4.Text = Convert.ToString(temp);
                label5.Text = Get_result(temp);
                label5.ForeColor = Get_color(temp);
            }
            else
                label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BMI_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
    }
}
