using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch03_Test_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_math_Click(object sender, EventArgs e)
        {
            const double PI = Math.PI;
            double n1 = Convert.ToDouble(tb_radios.Text);
            double result;

            if (rb_perimeter.Checked)
            {
                result = 2 * n1 * PI;
            }
            else if (rb_area.Checked)
            {
                result = n1 * n1 * PI;
            }
            else
            {
                result = 2 * n1;
            }

            tb_result.Text = result.ToString("0.000000");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_r_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
