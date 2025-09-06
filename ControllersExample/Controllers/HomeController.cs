using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("/")]
        public ContentResult Index()
        {
            return Content("<h1>This is the content</h1>", "text/html");
        }


        [Route("contact/{mobile:length(10)}")]
        public string Contact(string mobile)
        {
            return $"Hello from contact:{mobile}";
        }

        [Route("/person")]
        public JsonResult Person()
        {
            var person = new
            {
                Id = 1,
                Name = "John Doe",
                Age = 30,
                Email = "john.doe@example.com"
            };
            return Json(person);
        }
    }
}
