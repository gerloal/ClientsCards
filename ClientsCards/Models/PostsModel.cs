
using ClientsCards.Shared;

namespace ClientsCards.Models
{


    public class PostsModel
    {

        public List<Post> postsList = new List<Post>(); 
        
        public int? UserId { get; set; }


    }

    public class UserModel
    {

        public List<User> userList = new List<User>();


    }
}
