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


        [Route("contact/{mobile:length(10)}")]
        public string Contact(string mobile)
        {
            return $"Hello from contact:{mobile}";
        }

        [Route("about")]
        public string About()
        {
            return "Hello from about";
        }
    }
}
