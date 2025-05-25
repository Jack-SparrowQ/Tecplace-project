using CommonUtils.Interfaces;
namespace PostForm
{
    public partial class PostForm1 : Form
    {
        private INavegation nav;
        public PostForm1(INavegation nav)
        {
            InitializeComponent();
            this.nav = nav;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
