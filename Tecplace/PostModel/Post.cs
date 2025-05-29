using System.Drawing;

namespace PostModel
{
    public class Post
    {
            public int Id { get; set; }
            public Image img { get; set; }
            public string Description { get; set; }
            public DateTime date { get; set; }

            public String price { get; set; }
    }
}
