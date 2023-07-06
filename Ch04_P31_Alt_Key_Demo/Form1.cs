using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P31_Alt_Key_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   /*
            int cnt = Convert.ToInt32(Text);
            cnt++;
            Text = cnt.ToString();
            */
            Text = (Convert.ToInt32(Text)+1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = "0";
        }
    }
}
