using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
            label2.Text = "крассный";
            label3.Text = "крассный";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
            label2.BackColor = Color.Blue;
            label1.Text = "синий";
            label2.Text = "синий";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
            label2.BackColor = Color.Yellow;
            label3.BackColor = Color.Yellow;
            label1.Text = "желтый";
            label2.Text = "желтый";
            label3.Text = "желтый";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label1.Text = "label1";
            label2.Text = "label2";
            label3.Text = "label3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}

















