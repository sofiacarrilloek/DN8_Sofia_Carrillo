using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly IMembersAppServices _membersAppServices;
        public MembersController(IMembersAppServices membersAppServices)
        {
            _membersAppServices = membersAppServices;
        }

        public IActionResult Index()
        {
            List<Member> members = _membersAppServices.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            Log.Information("Se ejecutó la acción Index del controlador Members");


            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int memberId)
        {
            _membersAppServices.DeleteMember(memberId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            _membersAppServices.AddMember(member);

            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(int memberId)
        {
            Member member = _membersAppServices.GetMember(memberId);

            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _membersAppServices.EditMember(member);

            return RedirectToAction("Index");
        }
        public IActionResult Test()
        {
            return View();
        }

    }
}
