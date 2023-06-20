using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMembersAppServices _membersAppServices;

        public HomeController(IMembersAppServices membersAppServices)
        {
            _membersAppServices = membersAppServices;
        }
        public IActionResult Index()
        {
            var members = _membersAppServices.GetMembers(); 

            return View(members);
        }
    }


}
