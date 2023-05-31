using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch01_P14_GUI_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_compute_sum_Click(object sender, EventArgs e)
        {
            double n1;
            n1 = Convert.ToDouble(tb_Num1.Text);

            double n2;
            n2 = Convert.ToDouble(tb_Num2.Text);

            double result;
            result = n1 + n2;
            tb_result.Text = result.ToString();
        }
    }
}
