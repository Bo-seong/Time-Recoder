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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage newform1 = new startPage();
            newform1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            concentrationPage newform4 = new concentrationPage();
            newform4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            restPage newform5 = new restPage();
            newform5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 newform6 = new Form6();
            newform6.Show();
        }
    }
}
