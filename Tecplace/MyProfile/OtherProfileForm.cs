using CommonUtils.Interfaces;

namespace MyProfile
{
    public partial class OtherProfileForm : Form
    {
        private INavegation nav;
        public OtherProfileForm(INavegation nav)
        {
            InitializeComponent();
            this.nav = nav;
        }

        public void OtherProfile_Load(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();
            button1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nav.ShowHome();
            this.Hide();
        }

        private void OtherProfileForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
