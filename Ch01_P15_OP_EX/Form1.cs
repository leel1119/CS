using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch01_P15_OP_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_compute_Click(object sender, EventArgs e)
        {
            double  n1,n2;
            n1 = Convert.ToDouble(tb_Num1.Text);
            n2 = Convert.ToDouble(tb_Num2.Text);
            double res;
            if (rb_add.Checked)
            {
                res = n1 + n2;
            }
            else if (rb_sub.Checked)
            {
                res = n1 - n2;
            }
            else if (rb_mul.Checked)
            {
                res = n1 * n2;
            }
            else
            { 
                res = n1 / n2;
            }

            tb_result.Text = res.ToString("0.0000");
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_Num1.BackColor = Color.LightBlue;
            tb_Num2.BackColor = Color.LightGreen;
            tb_result.BackColor = Color.Aqua;
        }
    }
}
