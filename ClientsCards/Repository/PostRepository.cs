using ClientsCards.Shared;

namespace ClientsCards.Repository
{
    public class PostsRepository: IPostsRepository
    {
        private readonly PostContext _context;

        public PostsRepository()
        {
            _context = new PostContext();

        }
        public PostsRepository(PostContext context) 
        { 
            _context = context;
        }
        public IEnumerable<Post> GetAll()
        {
            return _context.GellAll();
        }
        public IEnumerable<Post> GetByUser(User user)
        {
            return _context.UserPosts(user);
        }
    
        public bool Delete(int idPost)            
        {

            return _context.Delete(idPost);

        }


    }
}
