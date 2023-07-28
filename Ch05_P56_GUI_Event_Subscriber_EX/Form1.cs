using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch05_P56_GUI_Event_Subscriber_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ChangeLabel_Click(object sender, EventArgs e)
        {
            label1.Text = sender.ToString() + "\r\n" + e.ToString();
        }
    }
}
