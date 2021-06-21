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
	public partial class Shtange : Form
	{
		Data data;
		public delegate void Del();
		Del del;
		public Shtange(Data dt, Del a)
		{
			data = dt;
			del = a;
			InitializeComponent();
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			label7.Visible = false;
			label5.Text = "Нет данных";
			label5.ForeColor = Color.Black;
		}

		private void textBox2_Enter(object sender, EventArgs e)
		{
			label7.Visible = false;
			label6.Text = "Нет данных";
			label6.ForeColor = Color.Black;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
		bool Digit_string(string str)
		{
			for (int i = 0; i < str.Length; i++)
				if (!((str[i] >= '0' && str[i] <= '9') || str[i] == ' '))
					return false;
			return true;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			int res;
			if (textBox1.TextLength > 0 && Digit_string(textBox1.Text))
			{
				res = int.Parse(textBox1.Text);
				if (res >= 50)
				{
					label5.Text = "Отлично";
					label5.ForeColor = Color.Green;
				}
				if (res >= 40 && res < 50)
				{
					label5.Text = "Хорошо";
					label5.ForeColor = Color.OrangeRed;
				}
				if (res < 40)
				{
					label5.Text = "Плохо";
					label5.ForeColor = Color.Red;
				}
			}
			else
				label7.Visible = true;
			if (textBox2.TextLength > 0 && Digit_string(textBox2.Text))
			{
				res = int.Parse(textBox2.Text);
				if (res >= 40)
				{
					label6.Text = "Отлично";
					label6.ForeColor = Color.Green;
				}
				if (res >= 35 && res < 40)
				{
					label6.Text = "Хорошо";
					label6.ForeColor = Color.OrangeRed;
				}
				if (res < 35)
				{
					label6.Text = "Плохо";
					label6.ForeColor = Color.Red;
				}
			}
			else
				label7.Visible = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "Перед замером необходимо сделать три обычных цикла вдох-выдох, примерно на" +
				" 3/4 глубины полного вдоха. Затем, если проводится проба Штанге, задерживается дыхание на вдохе. " +
				"Проба Генчи проводится на полном выдохе. С помощью секундомера подсчитывается время задержки дыхания." +
				" После подсчетов необходимо записать полученные данные в соответствующие поля и нажать кнопку <Результат>" +
				" для получения результата тестирования";
			if (richTextBox1.Visible)
				richTextBox1.Visible = false;
			else
				richTextBox1.Visible = true;
		}

		private void Shtange_FormClosed(object sender, FormClosedEventArgs e)
		{
			del();
		}
	}
}
