using RestSharp;

namespace ClientsCards.Shared
{
    public class PostContext
    {

        static private string host = "http://jsonplaceholder.typicode.com/posts";

        public RestClient restClient = new RestClient(host);

        public PostContext() { }
        public List<Post> GellAll()
        {

            string address = $"/";

            var request = new RestRequest(address, Method.Get);

            RestResponse<List<Post>> restResponse = restClient.Execute<List<Post>>(request);

            return restResponse.Data ?? new List<Post>();

        }
        public Post UserPostsOne(User user)
        {
            string address = $"/"+user.id.ToString();

            var request = new RestRequest(address, Method.Get);


            RestResponse<Post> response = restClient.Execute<Post>(request);

            return response.Data ?? new Post();
            
        }

        public List<Post> UserPosts(User user)
        {
            string address = $"?userId=" + user.id.ToString();

            var request = new RestRequest(address, Method.Get);


            RestResponse<List<Post>> response = restClient.Execute<List<Post>>(request);

            return response.Data ?? new List<Post>();

        }
        public bool Delete(int IdPost)
        {
            string address = $"/"+IdPost.ToString();

            var request = new RestRequest(address, Method.Delete);

            RestResponse restResponse = restClient.Execute(request);

            return true;
        }
    }

    public class UserContext
    {

        static private string host = "http://jsonplaceholder.typicode.com/users";

        public RestClient restClient = new RestClient(host);

        public UserContext() { }
        public List<User> GetAll()
        {
            string address = $"/";

            var request = new RestRequest(address, Method.Get);


            RestResponse<List<User>> response = restClient.Execute<List<User>>(request);

            return response.Data ?? new List<User>();

        
        }
        
    }
}
