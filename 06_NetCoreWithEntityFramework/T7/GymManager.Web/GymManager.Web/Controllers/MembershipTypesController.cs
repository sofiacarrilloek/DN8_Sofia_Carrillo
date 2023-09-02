using GymManager.ApplicationServices.MembershipTypes;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypes _membershipAppServices;

        public MembershipTypesController(IMembershipTypes membershipType)
        {
            _membershipAppServices = membershipType;
        }

        public IActionResult Index()
        {
            List<MembershipType> membershipType = _membershipAppServices.GetMembershipTypes();
            MembershipListViewModel viewModel = new MembershipListViewModel();

            viewModel.MembershipTypes = membershipType;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int membershipId)
        {
            _membershipAppServices.DeleteMembershipType(membershipId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(MembershipType membership)
        {
            _membershipAppServices.AddMembershipType(membership);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int membershipId)
        {
            MembershipType membership = _membershipAppServices.GetMembershipType(membershipId);

            return View(membership);
        }

        [HttpPost]
        public IActionResult Edit(MembershipType memberhip)
        {
            _membershipAppServices.EditMembershipType(memberhip);

            return RedirectToAction("Index");
        }

    }
}
