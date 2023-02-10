using System;
using System.Windows.Forms;

namespace MainClientUI
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm newform1 = new startForm();
            newform1.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            chkAgree.Checked = false;
            btnRegister.Enabled = false;
            chkAgree.CheckStateChanged += chkAgree_CheckedChanged;
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgree.Checked) 
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
        }
    }
}
