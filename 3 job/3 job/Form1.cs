using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_job
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            listBox1.Text = null;
            listBox2.Text = null;
            int min = arr[0];
            Random r = new Random();
            int indexMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-101, 100);
            }
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    indexMin = i;
                }
            foreach (var item in arr)
            {
                listBox1.Text = listBox1.Text + Convert.ToString(item) + " ";
            }
            int temp = arr[arr.Length - 1];
            arr[arr.Length - 1] = min;
            arr[indexMin] = temp;
            foreach (var item in arr)
            {
                listBox2.Text = listBox2.Text + Convert.ToString(item) + " ";
            }
        }
    }
}
