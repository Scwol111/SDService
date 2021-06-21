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
    public partial class Norms : Form
    {
        Data data;
        public delegate void Del();
        Del del;
        class Normes
        {
            Color color;
            string text;
            public string Get_text
            {
                get { return text; }
            }
            public Color Get_Color
            {
                get { return color; }
            }
            public void Set_Info(int it)
            {
                switch(it)
                {
                    case 0:
                        text = "Удовлетворительно";
                        color = Color.OrangeRed;
                        break;
                    case 1:
                        text = "Хорошо";
                        color = Color.DarkGreen;
                        break;
                    case 2:
                        text = "Отлично";
                        color = Color.Green;
                        break;
                    case 3:
                        text = "Не Удовлетворительно";
                        color = Color.Red;
                        break;
                    case 4:
                        text = "Нет данных";
                        color = Color.Black;
                        break;
                }
            }
            public void Set_Label(Label label)
            {
                label.Text = text;
                label.ForeColor = color;
            }
        }
        public Norms(Data dt, Del a)
        {
            data = dt;
            del = a;
            InitializeComponent();
            if (!data.Full())
            {
                label1.Visible = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
            }
            else if (data.Gender == "Мужской")
            {
                label3.Text = "Бег 3000 м (мин, сек)";
                label4.Text = "Подтягивание из виза лежа на высокой перекладине";
                label10.Text = "Бег на лыжах 5 км (мин, сек)";
                label19.Visible = true;
                label21.Visible = true;
                textBox10.Visible = true;
                textBox10.Enabled = true;
            }
            else if (data.Special)
                label3.Text = "Бег 1000 м (мин, сек)";
        }

        private void Norms_FormClosed(object sender, FormClosedEventArgs e)
        {
            del();
        }
        bool Digit_string(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (!((str[i] >= '0' && str[i] <= '9') || str[i] == ' ' || str[i] == ','))
                    return false;
            return true;
        }
        private void Norms_Load(object sender, EventArgs e)
        {

        }
        private void Male_standart()
        {
            Normes normes = new Normes();
            if (textBox1.TextLength > 0 && Digit_string(textBox1.Text))//100m
            {
                float res = float.Parse(textBox1.Text);
                if (res > 15.5)
                    normes.Set_Info(3);
                if (res <= 15.5 && res > 14.8)
                    normes.Set_Info(0);
                if (res <= 14.8 && res > 13.5)
                    normes.Set_Info(1);
                if (res <= 13.5)
                    normes.Set_Info(2);
                normes.Set_Label(label11);
                normes.Set_Info(4);
            }
            if (textBox2.TextLength > 0 && Digit_string(textBox2.Text))//3000m
            {
                float res = float.Parse(textBox2.Text);
                if (res > 15)
                    normes.Set_Info(3);
                if (res <= 15 && res > 13.3)
                    normes.Set_Info(0);
                if (res <= 13.3 && res > 12.3)
                    normes.Set_Info(1);
                if (res < 12.3)
                    normes.Set_Info(2);
                normes.Set_Label(label12);
                normes.Set_Info(4);
            }
            if (textBox3.TextLength > 0 && Digit_string(textBox3.Text))//podtagivanie
            {
                int res = int.Parse(textBox3.Text);
                if (res < 6)
                    normes.Set_Info(3);
                if (res >= 6 && res < 10)
                    normes.Set_Info(0);
                if (res >= 10 && res < 13)
                    normes.Set_Info(1);
                if (res >= 13)
                    normes.Set_Info(2);
                normes.Set_Label(label14);
                normes.Set_Info(4);
            }
            if (textBox10.TextLength > 0 && Digit_string(textBox10.Text))//girya
            {
                int res = int.Parse(textBox10.Text);
                if (res < 15)
                    normes.Set_Info(3);
                if (res >= 15 && res < 30)
                    normes.Set_Info(0);
                if (res >= 30 && res < 40)
                    normes.Set_Info(1);
                if (res >= 40)
                    normes.Set_Info(2);
                normes.Set_Label(label21);
                normes.Set_Info(4);
            }
            if (textBox4.TextLength > 0 && Digit_string(textBox4.Text))//otgimaniya
            {
                int res = int.Parse(textBox4.Text);
                if (res < 28)
                    normes.Set_Info(3);
                if (res >= 28 && res < 32)
                    normes.Set_Info(0);
                if (res >= 32 && res < 44)
                    normes.Set_Info(1);
                if (res >= 44)
                    normes.Set_Info(2);
                normes.Set_Label(label13);
                normes.Set_Info(4);
            }
            if (textBox5.TextLength > 0 && Digit_string(textBox5.Text))//naklon
            {
                int res = int.Parse(textBox5.Text);
                if (res < 5)
                    normes.Set_Info(3);
                if (res >= 5 && res < 7)
                    normes.Set_Info(0);
                if (res >= 7 && res < 13)
                    normes.Set_Info(1);
                if (res >= 13)
                    normes.Set_Info(2);
                normes.Set_Label(label16);
                normes.Set_Info(4);
            }
            if (textBox6.TextLength > 0 && Digit_string(textBox6.Text))//prigok
            {
                int res = int.Parse(textBox6.Text);
                if (res < 200)
                    normes.Set_Info(3);
                if (res >= 200 && res < 230)
                    normes.Set_Info(0);
                if (res >= 230 && res < 240)
                    normes.Set_Info(1);
                if (res >= 240)
                    normes.Set_Info(2);
                normes.Set_Label(label15);
                normes.Set_Info(4);
            }
            if (textBox7.TextLength > 0 && Digit_string(textBox7.Text))//press
            {
                int res = int.Parse(textBox7.Text);
                if (res < 33)
                    normes.Set_Info(3);
                if (res >= 33 && res < 37)
                    normes.Set_Info(0);
                if (res >= 37 && res < 48)
                    normes.Set_Info(1);
                if (res >= 48)
                    normes.Set_Info(2);
                normes.Set_Label(label18);
                normes.Set_Info(4);
            }
            if (textBox8.TextLength > 0 && Digit_string(textBox8.Text))//plavanie
            {
                float res = float.Parse(textBox8.Text);
                if (res > 1)
                    normes.Set_Info(0);
                if (res <= 1 && res > 0.42)
                    normes.Set_Info(1);
                if (res <= 0.42)
                    normes.Set_Info(2);
                normes.Set_Label(label17);
                normes.Set_Info(4);
            }
            if (textBox9.TextLength > 0 && Digit_string(textBox9.Text))//lizi
            {
                float res = float.Parse(textBox9.Text);
                if (res > 27)
                    normes.Set_Info(3);
                if (res <= 27 && res > 25.3)
                    normes.Set_Info(0);
                if (res <= 25.3 && res > 23.3)
                    normes.Set_Info(1);
                if (res <= 23.3)
                    normes.Set_Info(2);
                normes.Set_Label(label20);
                normes.Set_Info(4);
            }
        }
        private void Female_standart()
        {
            Normes normes = new Normes();
            if (textBox1.TextLength > 0 && Digit_string(textBox1.Text))//100m
            {
                float res = float.Parse(textBox1.Text);
                if (res > 18)
                    normes.Set_Info(3);
                if (res <= 18 && res > 17)
                    normes.Set_Info(0);
                if (res <= 17 && res > 16.5)
                    normes.Set_Info(1);
                if (res <= 16.5)
                    normes.Set_Info(2);
                normes.Set_Label(label11);
                normes.Set_Info(4);
            }
            if (textBox2.TextLength > 0 && Digit_string(textBox2.Text))//2000m
            {
                float res = float.Parse(textBox2.Text);
                if (res > 11.15)
                    normes.Set_Info(0);
                if (res <= 11.15 && res > 10.3)
                    normes.Set_Info(1);
                if (res < 10.3)
                    normes.Set_Info(2);
                normes.Set_Label(label12);
                normes.Set_Info(4);
            }
            if (textBox3.TextLength > 0 && Digit_string(textBox3.Text))//podtagivanie
            {
                int res = int.Parse(textBox3.Text);
                if (res < 8)
                    normes.Set_Info(3);
                if (res >= 8 && res < 15)
                    normes.Set_Info(0);
                if (res >= 15 && res < 20)
                    normes.Set_Info(1);
                if (res >= 20)
                    normes.Set_Info(2);
                normes.Set_Label(label14);
                normes.Set_Info(4);
            }
            if (textBox4.TextLength > 0 && Digit_string(textBox4.Text))//otgimaniya
            {
                int res = int.Parse(textBox4.Text);
                if (res < 5)
                    normes.Set_Info(3);
                if (res >= 5 && res < 12)
                    normes.Set_Info(0);
                if (res >= 12 && res < 16)
                    normes.Set_Info(1);
                if (res >= 16)
                    normes.Set_Info(2);
                normes.Set_Label(label13);
                normes.Set_Info(4);
            }
            if (textBox5.TextLength > 0 && Digit_string(textBox5.Text))//naklon
            {
                int res = int.Parse(textBox5.Text);
                if (res < 5)
                    normes.Set_Info(3);
                if (res >= 5 && res < 11)
                    normes.Set_Info(0);
                if (res >= 11 && res < 16)
                    normes.Set_Info(1);
                if (res >= 16)
                    normes.Set_Info(2);
                normes.Set_Label(label16);
                normes.Set_Info(4);
            }
            if (textBox6.TextLength > 0 && Digit_string(textBox6.Text))//prigok
            {
                int res = int.Parse(textBox6.Text);
                if (res < 150)
                    normes.Set_Info(3);
                if (res >= 150 && res < 180)
                    normes.Set_Info(0);
                if (res >= 180 && res < 195)
                    normes.Set_Info(1);
                if (res >= 195)
                    normes.Set_Info(2);
                normes.Set_Label(label15);
                normes.Set_Info(4);
            }
            if (textBox7.TextLength > 0 && Digit_string(textBox7.Text))//press
            {
                int res = int.Parse(textBox7.Text);
                if (res < 25)
                    normes.Set_Info(3);
                if (res >= 25 && res < 40)
                    normes.Set_Info(0);
                if (res >= 40 && res < 47)
                    normes.Set_Info(1);
                if (res >= 47)
                    normes.Set_Info(2);
                normes.Set_Label(label18);
                normes.Set_Info(4);
            }
            if (textBox8.TextLength > 0 && Digit_string(textBox8.Text))//plavanie
            {
                float res = float.Parse(textBox8.Text);
                if (res > 1.1)
                    normes.Set_Info(1);
                if (res <= 1.1)
                    normes.Set_Info(2);
                normes.Set_Label(label17);
                normes.Set_Info(4);
            }
            if (textBox9.TextLength > 0 && Digit_string(textBox9.Text))//lizi
            {
                float res = float.Parse(textBox9.Text);
                if (res > 19.3)
                    normes.Set_Info(0);
                if (res <= 19.3 && res > 18)
                    normes.Set_Info(1);
                if (res <= 18)
                    normes.Set_Info(2);
                normes.Set_Label(label20);
                normes.Set_Info(4);
            }
        }
        private void Male_special()
        {
            Normes normes = new Normes();
            if (textBox1.TextLength > 0 && Digit_string(textBox1.Text))//100m
            {
                float res = float.Parse(textBox1.Text);
                if (res > 18)
                    normes.Set_Info(3);
                if (res <= 18 && res > 17)
                    normes.Set_Info(0);
                if (res <= 17 && res > 16.5)
                    normes.Set_Info(1);
                if (res <= 16.5)
                    normes.Set_Info(2);
                normes.Set_Label(label11);
                normes.Set_Info(4);
            }
            if (textBox2.TextLength > 0 && Digit_string(textBox2.Text))//3000m
            {
                float res = float.Parse(textBox2.Text);
                if (res > 15.3)
                    normes.Set_Info(0);
                if (res <= 15.3 && res > 14)
                    normes.Set_Info(1);
                if (res < 14)
                    normes.Set_Info(2);
                normes.Set_Label(label12);
                normes.Set_Info(4);
            }
            if (textBox3.TextLength > 0 && Digit_string(textBox3.Text))//podtagivanie
            {
                int res = int.Parse(textBox3.Text);
                if (res < 1)
                    normes.Set_Info(3);
                if (res >= 1 && res < 5)
                    normes.Set_Info(0);
                if (res >= 5 && res < 10)
                    normes.Set_Info(1);
                if (res >= 10)
                    normes.Set_Info(2);
                normes.Set_Label(label14);
                normes.Set_Info(4);
            }
            if (textBox10.TextLength > 0 && Digit_string(textBox10.Text))//girya
            {
                int res = int.Parse(textBox10.Text);
                if (res < 15)
                    normes.Set_Info(3);
                if (res >= 15 && res < 18)
                    normes.Set_Info(0);
                if (res >= 18 && res < 33)
                    normes.Set_Info(1);
                if (res >= 33)
                    normes.Set_Info(2);
                normes.Set_Label(label21);
                normes.Set_Info(4);
            }
            if (textBox4.TextLength > 0 && Digit_string(textBox4.Text))//otgimaniya
            {
                int res = int.Parse(textBox4.Text);
                if (res < 22)
                    normes.Set_Info(3);
                if (res >= 22 && res < 25)
                    normes.Set_Info(0);
                if (res >= 25 && res < 39)
                    normes.Set_Info(1);
                if (res >= 39)
                    normes.Set_Info(2);
                normes.Set_Label(label13);
                normes.Set_Info(4);
            }
            if (textBox5.TextLength > 0 && Digit_string(textBox5.Text))//naklon
            {
                int res = int.Parse(textBox5.Text);
                if (res < 1)
                    normes.Set_Info(3);
                if (res >= 1 && res < 5)
                    normes.Set_Info(0);
                if (res >= 5 && res < 7)
                    normes.Set_Info(1);
                if (res >= 7)
                    normes.Set_Info(2);
                normes.Set_Label(label16);
                normes.Set_Info(4);
            }
            if (textBox6.TextLength > 0 && Digit_string(textBox6.Text))//prigok
            {
                int res = int.Parse(textBox6.Text);
                if (res < 170)
                    normes.Set_Info(3);
                if (res >= 170 && res < 190)
                    normes.Set_Info(0);
                if (res >= 190 && res < 200)
                    normes.Set_Info(1);
                if (res >= 200)
                    normes.Set_Info(2);
                normes.Set_Label(label15);
                normes.Set_Info(4);
            }
            if (textBox7.TextLength > 0 && Digit_string(textBox7.Text))//press
            {
                int res = int.Parse(textBox7.Text);
                if (res < 30)
                    normes.Set_Info(3);
                if (res >= 30 && res < 35)
                    normes.Set_Info(0);
                if (res >= 35 && res < 45)
                    normes.Set_Info(1);
                if (res >= 45)
                    normes.Set_Info(2);
                normes.Set_Label(label18);
                normes.Set_Info(4);
            }
            if (textBox8.TextLength > 0 && Digit_string(textBox8.Text))//plavanie
            {
                float res = float.Parse(textBox8.Text);
                if (res > 1.5)
                    normes.Set_Info(0);
                if (res <= 1.5 && res > 1.15)
                    normes.Set_Info(1);
                if (res <= 1.15)
                    normes.Set_Info(2);
                normes.Set_Label(label17);
                normes.Set_Info(4);
            }
            if (textBox9.TextLength > 0 && Digit_string(textBox9.Text))//lizi
            {
                float res = float.Parse(textBox9.Text);
                if (res < 27)
                    normes.Set_Info(0);
                if (res <= 27 && res > 25.3)
                    normes.Set_Info(1);
                if (res <= 25.3)
                    normes.Set_Info(2);
                normes.Set_Label(label20);
                normes.Set_Info(4);
            }
        }
        private void Female_special()
        {
            Normes normes = new Normes();
            if (textBox1.TextLength > 0 && Digit_string(textBox1.Text))//100m
            {
                float res = float.Parse(textBox1.Text);
                if (res > 22)
                    normes.Set_Info(3);
                if (res <= 22 && res > 20)
                    normes.Set_Info(0);
                if (res <= 20 && res > 18)
                    normes.Set_Info(1);
                if (res <= 18)
                    normes.Set_Info(2);
                normes.Set_Label(label11);
                normes.Set_Info(4);
            }
            if (textBox2.TextLength > 0 && Digit_string(textBox2.Text))//1000m
            {
                float res = float.Parse(textBox2.Text);
                if (res > 11.15)
                    normes.Set_Info(0);
                if (res <= 11.15 && res > 10.3)
                    normes.Set_Info(1);
                if (res < 10.3)
                    normes.Set_Info(2);
                normes.Set_Label(label12);
                normes.Set_Info(4);
            }
            if (textBox3.TextLength > 0 && Digit_string(textBox3.Text))//podtagivanie
            {
                int res = int.Parse(textBox3.Text);
                if (res < 7)
                    normes.Set_Info(3);
                if (res >= 7 && res < 10)
                    normes.Set_Info(0);
                if (res >= 10 && res < 15)
                    normes.Set_Info(1);
                if (res >= 15)
                    normes.Set_Info(2);
                normes.Set_Label(label14);
                normes.Set_Info(4);
            }
            if (textBox4.TextLength > 0 && Digit_string(textBox4.Text))//otgimaniya
            {
                int res = int.Parse(textBox4.Text);
                if (res < 3)
                    normes.Set_Info(3);
                if (res >= 3 && res < 5)
                    normes.Set_Info(0);
                if (res >= 5 && res < 10)
                    normes.Set_Info(1);
                if (res >= 10)
                    normes.Set_Info(2);
                normes.Set_Label(label13);
                normes.Set_Info(4);
            }
            if (textBox5.TextLength > 0 && Digit_string(textBox5.Text))//naklon
            {
                int res = int.Parse(textBox5.Text);
                if (res < 5)
                    normes.Set_Info(3);
                if (res >= 5 && res < 7)
                    normes.Set_Info(0);
                if (res >= 7 && res < 10)
                    normes.Set_Info(1);
                if (res >= 10)
                    normes.Set_Info(2);
                normes.Set_Label(label16);
                normes.Set_Info(4);
            }
            if (textBox6.TextLength > 0 && Digit_string(textBox6.Text))//prigok
            {
                int res = int.Parse(textBox6.Text);
                if (res < 110)
                    normes.Set_Info(3);
                if (res >= 110 && res < 135)
                    normes.Set_Info(0);
                if (res >= 135 && res < 165)
                    normes.Set_Info(1);
                if (res >= 165)
                    normes.Set_Info(2);
                normes.Set_Label(label15);
                normes.Set_Info(4);
            }
            if (textBox7.TextLength > 0 && Digit_string(textBox7.Text))//press
            {
                int res = int.Parse(textBox7.Text);
                if (res < 15)
                    normes.Set_Info(3);
                if (res >= 15 && res < 20)
                    normes.Set_Info(0);
                if (res >= 20 && res < 30)
                    normes.Set_Info(1);
                if (res >= 30)
                    normes.Set_Info(2);
                normes.Set_Label(label18);
                normes.Set_Info(4);
            }
            if (textBox8.TextLength > 0 && Digit_string(textBox8.Text))//plavanie
            {
                float res = float.Parse(textBox8.Text);
                if (res <= 1.5)
                    normes.Set_Info(2);
                normes.Set_Label(label17);
                normes.Set_Info(4);
            }
            if (textBox9.TextLength > 0 && Digit_string(textBox9.Text))//lizi
            {
                float res = float.Parse(textBox9.Text);
                if (res > 25)
                    normes.Set_Info(0);
                if (res <= 25 && res > 21)
                    normes.Set_Info(1);
                if (res <= 21)
                    normes.Set_Info(2);
                normes.Set_Label(label20);
                normes.Set_Info(4);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (data.Full())
            {
                if (data.Gender == "Мужской")
                    if (data.Special)
                        Male_special();
                    else
                        Male_standart();
                else
                    if (data.Special)
                        Female_special();
                    else
                        Female_standart();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label11);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label12);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label14);
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label13);
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label16);
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label15);
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label18);
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label17);
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label20);
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            Normes normes = new Normes();
            normes.Set_Info(4);
            normes.Set_Label(label21);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
