using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_SenkronikAsenkronik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private async void btnCarp_Click(object sender, EventArgs e)
        {
           await CarpAsync(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void Topla(int number1,int number2)
        {
            MessageBox.Show($"Toplam: {number1 + number2}");
        }

        private void Carp(int number1, int number2)
        {
            Thread.Sleep(10000);
            MessageBox.Show($"Çarpım: {number1 * number2}");
        }

        private Task CarpAsync(int number1, int number2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show($"Çarpım: {number1 * number2}");
            });
        }
    }
}
