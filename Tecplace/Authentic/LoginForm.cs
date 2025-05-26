using CommonUtils.Interfaces;
using System.Text;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            } else
            {
                var client = new HttpClient();
                var json = @"{
                ""username"": """ + textBox_username.Text + @""",
                ""password"": """ + textBox_password.Text + @"""
            }";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync("http://localhost:8080/login", content);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        nav.ShowHome();
                    }
                    else
                    {
                        MessageBox.Show("Login failed: " + responseBody);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);

                }
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
