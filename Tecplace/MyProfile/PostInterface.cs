using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonUtils.Interfaces;
using PostModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Profiles_interfaces
{
    public partial class PostInterface : UserControl
    {
        private INavegation nav;
        public PostInterface(Post post, INavegation nav)
        {
            this.nav = nav;
            InitializeComponent();
           label_price.Text = post.price;
            
        }

        private void pictureBox_img_Click(object sender, EventArgs e)
        {
            //nav.ShowPostForm();
        }
    }
}
