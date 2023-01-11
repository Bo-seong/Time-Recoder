using System;
using System.Windows.Forms;

namespace buttontest
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage newform1 = new startPage();
            newform1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_userName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
