using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P45_TextSelection_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_Text.SelectionStart = 0;
            tb_Text.SelectionLength = Convert.ToInt32(tb_number.Text);
            tb_Text.Focus();
        }

        private void tb_number_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_number_TextChanged(object sender, EventArgs e)
        {
            bt_select.Text = $"選取{tb_number.Text}個字";
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            lb_Output.Text = tb_Text.SelectedText + "/" + tb_Text.SelectionStart + "/" + tb_Text.SelectionLength ;
            tb_Text.Focus() ;
        }
    }
}
