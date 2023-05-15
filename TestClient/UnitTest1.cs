using ClientsCards.Repository;
using ClientsCards.Shared;
using Microsoft.AspNetCore.Mvc;

namespace TestClient
{
    public class Tests
    {
    
        [Test]
        public void GetUsersList()
        {
            var userRepository = new UserRepository(new UserContext());          

            var model = userRepository.GetAll();
            
            Assert.IsTrue(model.Count<User>() > 0 );

        }
        [Test]
        public void GetUsersName()
        {
            string nameUser = "Clementine Bauch";

            var userRepository = new UserRepository(new UserContext());

            var model = userRepository.GetAll();

            User user = new User
            {
                name = "ERROR"
            };

            user = model.First(x => x.name.Equals(nameUser));

            Assert.IsTrue(user.name.Equals(nameUser));

        }
        [Test]
        public void GetPost()
        {
            var userRepository = new UserRepository(new UserContext());

            var userModel = userRepository.GetAll();

            User user = userModel.First<User>();

            var postRepository = new PostsRepository(new PostContext());

            var modelo = postRepository.GetByUser(user);

            Assert.IsTrue(modelo.Count<Post>() > 0);

        }
        [Test]
        public void GetDetePost()
        {

            var postRepository = new PostsRepository(new PostContext());

            var modelo = postRepository.Delete(1);

            Assert.IsTrue(modelo);

        }


    }
}