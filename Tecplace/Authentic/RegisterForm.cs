using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using CommonUtils.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;

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

        private async void button1_Click(object sender, EventArgs e)
        {

            if (textBox_username.Text == "" || textBox_email.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            } else
            {

                var client = new HttpClient();

                var json = @"{
                ""username"": """ + textBox_username.Text + @""",
                ""email"": """ + textBox_email.Text + @""",
                ""password"": """ + textBox_password.Text + @"""
            }"
                ;

                //tring json = System.Text.Json.JsonSerializer.Serialize(user);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("http://localhost:8080/register", content);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registration successful!");
                        this.Hide();
                        nav.ShowLogin();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed: " + responseBody);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);

                }
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
