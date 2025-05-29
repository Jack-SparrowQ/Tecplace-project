using PostModel;
namespace PostsService
{
    public class Class1
    {
        private List<Post> posts = new List<Post>();

        public List<Post> GetPosts()
        {
            return posts.OrderByDescending(p => p.date).ToList();
        }

        public void AddPost(Post post)
        {
            posts.Add(post);
        }
    }
}
