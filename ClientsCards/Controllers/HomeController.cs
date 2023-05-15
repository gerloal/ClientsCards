using ClientsCards.Models;
using ClientsCards.Repository;
using ClientsCards.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClientsCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private IUsersRepository _userRepository;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _userRepository = new UserRepository(new UserContext());
         
            _logger = logger;
        }

        public IActionResult Index()
        {

            var model = _userRepository.GetAll();

            return View(model);
        }
        public IActionResult ViewPosts(int UserId)
        {
            return View(new PostsModel { UserId = UserId });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}