namespace Ch02_Welcome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_msg.Text = "歡迎來到職訓局";
        }
    }
}