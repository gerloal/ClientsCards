using ClientsCards.Shared;

namespace ClientsCards.Repository
{
    public interface IPostsRepository
    {
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetByUser(User user);
        bool Delete(int postID);
    }
}
