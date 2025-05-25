using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostModule;
using CommonUtils.Interfaces;

namespace Main_project
{
    public partial class PostBox : UserControl
    {
        private INavegation nav;
        public PostBox(Post post, INavegation nav)
        {
            InitializeComponent();
            nameUser.Text = post.Author;
            date.Text = post.date.ToString("dd/MM/yyyy hh:mm tt");
            description.Text = post.Contenido;
            this.nav = nav;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ImgPost_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void nameUser_Click(object sender, EventArgs e)
        {
            nav.ShowOtherProfile();
        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {
            nav.ShowOtherProfile();
        }
    }
}
