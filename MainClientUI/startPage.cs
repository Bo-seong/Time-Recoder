using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainClientUI
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            mainPage newform2 = new mainPage();
            newform2.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPage newform3 = new SignUpPage();
            newform3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_input_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
