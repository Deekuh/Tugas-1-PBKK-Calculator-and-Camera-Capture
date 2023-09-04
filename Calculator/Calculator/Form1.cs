using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nilai1 = double.Parse(textBox1.Text);
            double nilai2 = double.Parse(textBox2.Text);
            double hasil;
            hasil = nilai1 + nilai2;
            textBox3.Text = hasil.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double nilai1 = double.Parse(textBox1.Text);
            double nilai2 = double.Parse(textBox2.Text);
            double hasil;
            hasil = Math.Round(nilai1 / nilai2, 3);
            textBox3.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double nilai1 = double.Parse(textBox1.Text);
            double nilai2 = double.Parse(textBox2.Text);
            double hasil;
            hasil = nilai1 - nilai2;
            textBox3.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double nilai1 = double.Parse(textBox1.Text);
            double nilai2 = double.Parse(textBox2.Text);
            double hasil;
            hasil = nilai1 * nilai2;
            textBox3.Text = hasil.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
