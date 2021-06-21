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
    public partial class Form1 : Form
    {
        Data data = new Data();
        public Form1()
        {       
            InitializeComponent();
        }
        void Data_copy(Data dt)
        {
            data.Chest_girh = dt.Chest_girh;
            data.Chest_girh_in = dt.Chest_girh_in;
            data.Chest_girh_out = dt.Chest_girh_out;
            data.Gender = dt.Gender;
            data.Height = dt.Height;
            data.Thigh = dt.Thigh;
            data.Waist = dt.Waist;
            data.Weight = dt.Weight;
            data.Years = dt.Years;
            data.Special = dt.Special;
        }
        private void button1_Click(object sender, EventArgs e)//input data
        {
            Input input = new Input(Data_copy, data, Show);
            input.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)//BMI
        {
            BMI bmi = new BMI(data, Show);
            bmi.Show();
            Hide();
        }

        private void button14_Click(object sender, EventArgs e)//close
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)//chest_in_out
        {
            Chest_in_out chest = new Chest_in_out(data, Show);
            chest.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)//erisman
        {
            Erisman erisman = new Erisman(data, Show);
            erisman.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)//Waist_to_hip
        {
            Waist_to_Hip_ratio waist_To_ = new Waist_to_Hip_ratio(data, Show);
            waist_To_.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)//crepost
        {
            Crepost crepost = new Crepost(data, Show);
            crepost.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)//Funct_sost
        {
            Funct_sost funct = new Funct_sost(data, Show);
            funct.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)//GEL
        {
            GEL gel = new GEL(data, Show);
            gel.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)//prised
        {
            Prised prised = new Prised(data, Show);
            prised.Show();
            Hide();
        }

        private void button13_Click(object sender, EventArgs e)//kuper
        {
            Kuper kuper = new Kuper(data, Show);
            kuper.Show();
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)//shatnge
        {
            Shtange shtange = new Shtange(data, Show);
            shtange.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)//garvard
        {
            Garvard garvard = new Garvard(data, Show);
            garvard.Show();
            Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Norms norms = new Norms(data, Show);
            norms.Show();
            Hide();
        }
    }
    public class Data
    {
        int height;
        int weight;
        int chest_girth;
        int chest_girth_in;
        int chest_girth_out;
        int waist;
        int thigh;
        int years;
        string gender;
        bool special;
        public Data()
        {
            height = -1;
            weight = -1;
            chest_girth = -1;
            chest_girth_in = -1;
            chest_girth_out = -1;
            waist = -1;
            thigh = -1;
            years = -1;
            gender = "ZERO";
            special = false;
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Chest_girh
        {
            get { return chest_girth; }
            set { chest_girth = value; }
        }
        public int Chest_girh_in
        {
            get { return chest_girth_in; }
            set { chest_girth_in = value; }
        }
        public int Chest_girh_out
        {
            get { return chest_girth_out; }
            set { chest_girth_out = value; }
        }
        public int Waist
        {
            get { return waist; }
            set { waist = value; }
        }
        public int Thigh
        {
            get { return thigh; }
            set { thigh = value; }
        }
        public int Years
        {
            get { return years; }
            set { years = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public bool Special
        {
            get { return special; }
            set { special = value; }
        }
        public bool Full()
        {
            if (height == -1)
                return false;
            if (weight == -1)
                return false;
            if (chest_girth == -1)
                return false;
            if (chest_girth_in == -1)
                return false;
            if (chest_girth_out == -1)
                return false;
            if (waist == -1)
                return false;
            if (thigh == -1)
                return false;
            if (years == -1)
                return false;
            if (gender == "ZERO")
                return false;
            return true;
        }
    }

}
