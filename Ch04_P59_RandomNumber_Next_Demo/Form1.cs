using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P59_RandomNumber_Next_Demo
{
    public partial class Form1 : Form
    {
        Random rd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_message.Clear();
            for (int i = 0; i < 10; i++) 
            {
                tb_message.Text += rd.Next().ToString() + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            tb_message.Clear();
            
            if (int.TryParse(tb_a.Text, out int temp))
            {
                int a = int.Parse(tb_a.Text);
                for (int i = 0; i < 10; i++)
                {
                    tb_message.Text += rd.Next(a).ToString() + "\r\n";
                }
            }
            else
            { 
                MessageBox.Show("Wrong input type");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            tb_message.Clear();
            if (int.TryParse(tb_a.Text, out int temp_a) && int.TryParse(tb_b.Text, out int temp_b))
            {
                int a = int.Parse(tb_a.Text);
                int b = int.Parse(tb_b.Text);
                for (int i = 0; i < 10; i++)
                {
                     tb_message.Text += rd.Next(a,b).ToString() + "\r\n";
                }
        }
            else
            { 
                MessageBox.Show("Wrong input type");
            }
}

        private void button4_Click(object sender, EventArgs e)
        {
            tb_message.Clear();
            for (int i = 0; i < 10; i++)
            {
                tb_message.Text += rd.NextDouble().ToString() + "\r\n";
            }
        }
    }
}
