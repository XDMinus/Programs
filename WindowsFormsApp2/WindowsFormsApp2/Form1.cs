using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Text = "телекоммуникационной и информационной";
            radioButton2.BackColor = Color.Red;
            label2.Text = "не верно";
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            radioButton1.BackColor = Color.Green;
            label2.Text = "Вернно"; 
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)

        { 
            radioButton3.BackColor = Color.Red;
            label2.Text = "не верно";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button2.Enabled = false;
            button3.Enabled = false;
            label3.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" верно");
            button1.Enabled = false;
            button3.Enabled = false;
            label4.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button2.Enabled = false;
            button1.Enabled = false;
            label5.BackColor = Color.Red;

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button4.Enabled = false;
            button5.Enabled = false;
            label8.BackColor = Color.Red;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("верно");
            button6.Enabled = false;
            button5.Enabled = false;
            label6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("верно");
            button8.Enabled = false;
            button9.Enabled = false;
            label10.BackColor = Color.Green; 
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button10.Enabled = false;
            button11.Enabled = false;
            label14.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("верно");
            button10.Enabled = false;
            button12.Enabled = false;
            label13.BackColor = Color.Green;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button4.Enabled = false;
            button6.Enabled = false;
            label7.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button7.Enabled = false;
            button9.Enabled = false;
            label11.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button7.Enabled = false;
            button8.Enabled = false;
            label12.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button12.Enabled = false;
            button11.Enabled = false;
            label9.BackColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("верно");
            button14.Enabled = false;
            button15.Enabled = false;
            label15.BackColor = Color.Green;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button13.Enabled = false;
            button15.Enabled = false;
            label16.BackColor = Color.Red;  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button13.Enabled = false;
            button14.Enabled = false;
            label16.BackColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("верно");
            button17.Enabled = false;
            button16.Enabled = false;
            label20.BackColor = Color.Green;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button18.Enabled = false;
            button16.Enabled = false;
            label19.BackColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button17.Enabled = false;
            button18.Enabled = false;
            label18.BackColor = Color.Red;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("верно");
            button26.Enabled = false;
            button25.Enabled = false;
            label26.BackColor = Color.Green;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button23.Enabled = false;
            button22.Enabled = false;
            label25.BackColor = Color.Red;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("не верно");
            button24.Enabled = false;
            button23.Enabled = false;
            label24.BackColor = Color.Red;
        }
    }
}
