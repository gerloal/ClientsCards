using ClientsCards.Repository;
using ClientsCards.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ClientsCards.Controllers
{
    public class PostsController : Controller
    {
        private IPostsRepository? _postRepository;

        
        public ActionResult Index(int idUser, string nameUser, string message)
        {

            ViewBag.UserID = idUser.ToString();
            ViewBag.UserName = nameUser;
            ViewBag.Message = message ?? "";

            _postRepository = new PostsRepository(new PostContext());

            User user = new User
            {
                id = idUser
            };
           

            var model = _postRepository.GetByUser(user);
          

            return View(model);
        }

        public ActionResult Delete(int PostId, int IdUser, string nameUser)
        {
            _postRepository = new PostsRepository(new PostContext());


            var _delete = _postRepository.Delete(PostId);
             

            return RedirectToAction("Index",new { idUser = IdUser, nameUser = nameUser, Message = "Deleted post number " + PostId.ToString()});
        }

    }
}
