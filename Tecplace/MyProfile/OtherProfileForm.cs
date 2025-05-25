namespace MyProfile
{
    public partial class OtherProfileForm : Form
    {
        public OtherProfileForm()
        {
            InitializeComponent();
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
    }
}
