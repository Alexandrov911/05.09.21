using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._09._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double d = b * b - 4 * a * c;
            if(d<0)
            {
                MessageBox.Show("Нет решений");

            }
            else if(d==0)
            {
                double x = -b / (2 * a);
                textBox4.Text = x.ToString();
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                textBox4.Text = x1.ToString();
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                textBox5.Text = x2.ToString();

            }
        }
        
    }
}
