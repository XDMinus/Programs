﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double c = Convert.ToDouble(textBox6.Text);
            double b = Convert.ToDouble(textBox6.Text);
            textBox5.Text = "результат" + Environment.NewLine;
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = Math.Pow(10, -2) / b * c;
                textBox5.Text += " x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
             



        }
    }
}
