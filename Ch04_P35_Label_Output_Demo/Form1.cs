using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P35_Label_Output_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_increase_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
        }

        private void bt_decrease_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label1.Text) > 0)
            {
                label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();
            }
            else
            { 
                label1.Text = "0";
            }
            
        }
    }
}
