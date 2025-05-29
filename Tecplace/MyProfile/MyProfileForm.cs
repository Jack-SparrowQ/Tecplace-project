using CommonUtils.Interfaces;
using System.Windows.Forms;
using PostsService;
using PostModel;
using Profiles_interfaces;
namespace MyProfile
{
    public partial class MyProfileForm : Form
    {
        private INavegation nav;
        private Class1 postsSevice;
        public MyProfileForm(INavegation nav)
        {
            postsSevice = new Class1();
            InitializeComponent();
            CargarFeed();

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

        private void button2_Click(object sender, EventArgs e)
        {
            nav.ShowNewPostForm();
        }

        private void CargarFeed()
        {
            flowLayoutPanel_posts.Controls.Clear();


            postsSevice.AddPost(new Post { price = "1.99", date = DateTime.Now });
            postsSevice.AddPost(new Post { price = "1.99", date = DateTime.Now.AddMinutes(-30) });
            postsSevice.AddPost(new Post { price = "1.99", date = DateTime.Now });
            postsSevice.AddPost(new Post { price = "1.99", date = DateTime.Now.AddMinutes(-30) });
            postsSevice.AddPost(new Post { price = "1.99", date = DateTime.Now });
            postsSevice.AddPost(new Post { price = "1.99", date = DateTime.Now.AddMinutes(-30) });

            var posts = postsSevice.GetPosts();

            foreach (var post in posts)
            {
                var postItem = new PostInterface(post, nav);
                flowLayoutPanel_posts.Controls.Add(postItem);
            }
        }

        private void flowLayoutPanel_posts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
