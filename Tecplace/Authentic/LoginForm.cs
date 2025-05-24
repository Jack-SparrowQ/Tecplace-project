using Main_project;

namespace Authentic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f2 = new RegisterForm();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "admin" && password == "admin")
            {
                FeedForm f1 = new FeedForm();
                this.Hide();
                f1.Show();
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
