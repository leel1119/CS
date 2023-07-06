using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P40_BMI_Demo
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

        private void button1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(tb_tall.Text);
            double weight = Convert.ToDouble(tb_weight.Text);
            double bmi = weight / (height * height);
            lb_BMI.Text = "BMI:" + bmi.ToString("0.000");
        }
    }
}
