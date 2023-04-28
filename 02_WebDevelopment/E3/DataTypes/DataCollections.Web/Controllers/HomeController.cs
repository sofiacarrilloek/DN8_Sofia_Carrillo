using Microsoft.AspNetCore.Mvc;

namespace DataCollections.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
