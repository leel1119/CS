using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P55_MessageBox.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_USD_2_NTD_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            result = Convert.ToDouble(tb_money.Text) * Convert.ToDouble(tb_Usd_rate.Text);
            DialogResult dr = MessageBox.Show("可兌換成台幣" + result, "美金兌換台幣", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK) 
            {
                tb_result.Text = " " + result;
            }
        }

        private void bt_JtoNTD_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            result = Convert.ToDouble(tb_money.Text) * Convert.ToDouble(tb_J_rate.Text);
            DialogResult dr = MessageBox.Show("可兌換成台幣" + result, "日元兌換台幣", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                tb_result.Text = " " + result;
            }
        }
    }
}
