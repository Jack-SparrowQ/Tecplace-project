using CommonUtils.Interfaces;
namespace Authentic
{
    public partial class LoginForm : Form
    {
        private INavegation nav;
        public LoginForm(INavegation nav)
        {
            InitializeComponent();
            this.nav = nav;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            nav.ShowRegister();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "admin" && password == "admin")
            {
                nav.ShowHome();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
