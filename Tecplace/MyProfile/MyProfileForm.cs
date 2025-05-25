using CommonUtils.Interfaces;
namespace MyProfile
{
    public partial class MyProfileForm : Form
    {
        private INavegation nav;
        public MyProfileForm(INavegation nav)
        {
            InitializeComponent();
            this.nav = nav;
        }

        public void MyProfile_Load(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();
            button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
