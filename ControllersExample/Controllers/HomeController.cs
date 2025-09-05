using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    //public class HomeController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
    public class HomeController
    {
        [Route("index")]
        [Route("/")]
        public string Index()
        {
            return "Hello from Index";
        }


        [Route("contact")]
        public string Contact()
        {
            return "Hello from contact";
        }

        [Route("about")]
        public string About()
        {
            return "Hello from about";
        }
    }
}
