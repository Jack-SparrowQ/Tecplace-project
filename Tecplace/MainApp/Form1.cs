using CommonUtils.Interfaces;
using Main_project;
using MyProfile;
using Authentic;

namespace MainApp
{
    public partial class Form1 : Form, INavegation
    {
        private FeedForm feedForm;
        private MyProfileForm myProfileForm;
        private OtherProfileForm otherProfileForm;
        public Form1()
        {
            InitializeComponent();
            feedForm = new FeedForm(this);
            myProfileForm = new MyProfileForm(this);
            otherProfileForm = new OtherProfileForm();
            LoginForm loginForm = new LoginForm(this);
            loginForm.ShowDialog();
        }

        public void ShowHome()
        {
            feedForm.Show();
            this.Hide();
        }

        public void ShowMyProfile()
        {
            myProfileForm.Show();
            this.Hide();
        }

        public void ShowOtherProfile()
        {
            otherProfileForm.Show();
            this.Hide();
        }

        public void ShowLogin()
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.ShowDialog();
            this.Hide();
        }

        public void ShowRegister()
        {
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.ShowDialog();
            this.Hide();
        }

    }
}
