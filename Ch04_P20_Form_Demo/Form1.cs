using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch04_P20_Form_Demo
{
    public partial class bt_ChangeBGcolorr : Form
    {
        public bt_ChangeBGcolorr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd_Dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bt_ChangeColor.BackColor = cd_Dialog.Color;
            }
            else { 
            bt_ChangeColor2.BackColor = Color.Red;
            }
        }

        private void bt_ChangeColor2_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd_Dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                bt_ChangeColor2.ForeColor = cd_Dialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd_Dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.BackColor = cd_Dialog.Color;
            }
        }
    }
}
