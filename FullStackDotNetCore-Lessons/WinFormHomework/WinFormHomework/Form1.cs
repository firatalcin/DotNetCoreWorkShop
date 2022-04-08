using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBox1.Text);
               
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lüften bir sayı giriniz.");
                }
                else if (number > 100)
                {
                    MessageBox.Show("Lütfen 100'den büyük bir sayı girmeyiniz."); 
                    textBox1.Clear();
                }
                else
                {
                    number++;
                    textBox1.Text = (number).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lüften bir sayı giriniz.");
                textBox1.Clear();
            }
        }
    }
}

