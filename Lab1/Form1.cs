using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab1
{
    public partial class Form1 : Form
    {
        bool znak = true;
        double a = 0, b = 0;
        public Form1()
        {
            InitializeComponent();
        } 
         
      
        private void button2_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "0") { textBox1.Text += 1; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 1;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("NaN") || textBox1.Text.Contains("НЕ ЧИСЛО") || textBox1.Text.Contains("бесконечность"))
            {
                MessageBox.Show("Недопустимые значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                label1.Text = "";
                a = 0; b = 0;
            }
            else
           if (textBox1.Text != "")
            {
                label1.Text = a.ToString();
                b = Convert.ToDouble(textBox1.Text);
                switch (parameter)
                {
                    case '+':
                        label1.Text = a.ToString()+'+'+b.ToString();
                        a = a + b;
                        break;
                    case '-':
                        label1.Text = a.ToString() + '-'+ b.ToString();
                        a = a - b;
                        break;
                    case 'x':
                        label1.Text = a.ToString() + 'x' + b.ToString();
                        a = a * b;
                        break;
                    case '/':
                        label1.Text = a.ToString() + '/' + b.ToString();
                        a = a / b;
                        break;
                }
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
            }
            else textBox1.Text = a.ToString();
        }
       

    char parameter = 'a';

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("NaN") || textBox1.Text.Contains("НЕ ЧИСЛО") || textBox1.Text.Contains("бесконечность"))
            {
                MessageBox.Show("Недопустимые значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                label1.Text = "";
                a = 0; b = 0;
            }
            else
            if (a == 0 && textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                label1.Text = a.ToString();
            }
            else if (textBox1.Text != "")
            {
                    label1.Text = a.ToString();
                b = Convert.ToDouble(textBox1.Text);
                switch (parameter)
                {
                    case '+':
                        label1.Text = a.ToString() + '+' + b.ToString();
                        a = a + b;
                        znak = true;
                        break;
                    case '-':
                        label1.Text = a.ToString() + '-' + b.ToString();
                        a = a - b;
                        znak = true;
                        break;
                    case 'x':
                        label1.Text = a.ToString() + 'x' + b.ToString();
                        a = a * b;
                        znak = true;
                        break;
                    case '/':
                        label1.Text = a.ToString() + '/' + b.ToString();
                        a = a / b;
                        znak = true;
                        break;
                }
            }
            parameter = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            a = 0;b = 0;

        }
        //
        private void button19_Click(object sender, EventArgs e)
        {
            if (znak== true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }
        //sqrt
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(a));
                a = 0; b = 0;
            }
            else return;
        }
        //pow
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Pow(a, 2));
                a = 0;b = 0;
            }
            else return;
        }
        //1/x
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(a = 1 / a);
                a = 0;b = 0;
            }
        }
        //coma
        private void button11_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "" || textBox1.Text.Contains (",")) { return; }
                else textBox1.Text += ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 0; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 2; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 3; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 4; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 5; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 5;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 6; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 6;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 7; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 7;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 8; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 8;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { textBox1.Text += 9; }
            else
            {
                textBox1.Clear();
                textBox1.Text += 9;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            RegistryKey mykey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            mykey.SetValue("lab1",Application.ExecutablePath);
         
        }

        private void button24_Click(object sender, EventArgs e)
        {
            RegistryKey mykey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            mykey.DeleteValue("lab1");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text[0] == '-' && textBox1.Text.Length == 2)
            {
                string s = textBox1.Text.Remove(textBox1.Text.Length - 2, 2);
                textBox1.Text = s;
            }
            else
            {
                string s = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                textBox1.Text = s;
            }
            return;
        }

    }


}
