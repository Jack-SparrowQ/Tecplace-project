using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonUtils.Interfaces;

namespace Authentic
{
    public partial class RegisterForm : Form
    {
        private INavegation nav;
        public RegisterForm(INavegation nav)
        {
            InitializeComponent();
            this.nav = nav;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            nav.ShowLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                MessageBox.Show("Registration Successful");
                this.Hide();
                nav.ShowLogin();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
