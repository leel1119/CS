using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P43_Multiline_TB_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            lb_show.Text = tb_password.Text + "\n" + tb_InputText.Text;
        }
    }
}
