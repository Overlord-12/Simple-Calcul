using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                if (b == 0)
                {
                    textBox3.Text = Convert.ToString("На ноль делить нельзя!");
                }
                else
                {
                    double result;
                    result = a / b;
                    textBox3.Text = Convert.ToString(result);
                }
            }
            catch
            {
                textBox3.Text = " Введены неверные значения";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double result;
                result = a * b;
                textBox3.Text = Convert.ToString(result);

            }
            catch
            {
                textBox3.Text = "Введены неверные значения";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                int result;
                result = Convert.ToInt32(a / b);
                textBox3.Text = Convert.ToString(result);
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double result;
                result = a * a;
                textBox3.Text = Convert.ToString(result);
            }
            catch
            {
                textBox3.Text = "Введены неверные значнеия";
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double result;
                result = a + b;
                textBox3.Text = Convert.ToString(result);
            }
            catch 
            {
                textBox3.Text = "Введены неверные значения";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double result;
                result = a - b;
                textBox3.Text = Convert.ToString(result);
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";

            }
        }

            private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double result;
                result = Math.Sqrt(a);
                textBox3.Text = Convert.ToString(result);
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double result = Math.Exp(a);
                textBox3.Text = Convert.ToString(result);
            }
            catch
            {
                textBox3.Text = "Введены неверные значения";

            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {


                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double b1 = (b * 3.14) / 180;
                double a1 = (a * 3.14) / 180;
                double result;
                double x1;
                double x2;
                double x3;
                double x4;
                double x5;
                double x6;
                x4 = Math.Sin(a);
                x3 = Math.Cos(a);
                x5 = Math.Tan(b - a);
                x6 = Math.Sin(a - b);
                x1 = Math.Sqrt(x4 + x5);
                if(x1 < 0)
                {
                    textBox3.Text = "Отрицательного корня не может быть.";
                }
                x2 = x3 + x6;
                if(x2 == 0)
                {
                    textBox3.Text = "На ноль делить нельзя";
                }
                else
                {
                    result = x1 / x2;
                    textBox3.Text = Convert.ToString(result);
                }
              
                    
 
            }
            catch
            {
                textBox3.Text = "Произошла ошибка в расчетах";
            }

            
        }
    }
}
