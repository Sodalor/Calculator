using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public double a, b;
        public int count;
        public bool log = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            int len = textBox1.Text.Length - 1;
            string txt = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < len; i++)
            {
                textBox1.Text = textBox1.Text + txt[i];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label1.Text = a.ToString() + "+";
                log = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label1.Text = a.ToString() + "-";
                log = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Text = a.ToString() + "*";
                log = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                log = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            calc();
            label1.Text = "";
        }
        private void calc()
        {
            try
            {
                switch (count)
                {
                    case 1:
                        b = a + double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 2:
                        b = a - double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 3:
                        b = a * double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 4:
                        if (double.Parse(textBox1.Text) == 0)
                        {
                            textBox1.Text = "Ошибка: Деление на ноль";
                        }
                        else
                        {
                            b = a / double.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                        }
                        break;
                    case 5:
                        b = Math.Pow(a, double.Parse(textBox1.Text));
                        textBox1.Text = b.ToString();
                        break;
                    case 6:
                        string value = textBox1.Text.Substring(1);
                        b = Math.Sqrt(double.Parse(value));
                        textBox1.Text = b.ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Неверный формат числа");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            a = 0;
            count = 0;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                label1.Text = a.ToString() + "^";
                log = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "√";
                count = 6;
                log = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (log == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                log = false;
            }
            else if (log == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                log = true;
            }
        }
    }
}
