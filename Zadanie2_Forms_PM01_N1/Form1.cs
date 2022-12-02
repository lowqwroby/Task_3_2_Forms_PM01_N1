using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2_Forms_PM01_N1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double f(double x)
		{
			double y;
			if ((x + 2) <= 1) y = x * x;
			else if (1 < (x + 2) && (x + 2) < 10) y = 1 / (x + 2);
			else y = x + 2;
			return y;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBox1.Text);
				double b = double.Parse(textBox2.Text);
				double h = double.Parse(textBox3.Text);

				for(double i = a; i <= b; i += h)
				{
					textBox4.Text += string.Format("f({0:f2}) = {1:f4}\r\n", i, f(i));
				}
			}
			catch
			{
				textBox4.Text = string.Format("Введены некорректные данные.");
			}
		}
	}
}
