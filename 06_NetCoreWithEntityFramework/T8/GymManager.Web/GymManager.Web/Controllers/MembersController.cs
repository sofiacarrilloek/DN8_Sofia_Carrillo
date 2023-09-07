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

        public async Task<IActionResult> Index()
        {
            List<Member> members = await _membersAppServices.GetMembersAsync();
            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            return View(viewModel);

        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Delete(int memberId)
        {
            await _membersAppServices.DeleteMemberAsync(memberId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int memberId)
        {
            Member member = await _membersAppServices.GetMemberAsync(memberId);

           /* MemberViewModel viewModel = new MemberViewModel
            {
                AllowNewsletter = member.AllowNewsletter,
                BirthDay = member.BirthDay,
                //CityId = member.City.Id,
                Email = member.Email,
                Id = member.Id,
                LastName = member.LastName,
                Name = member.Name,
            };*/
            
            //return view(viewmodel);
            return View(member);

        }

        [HttpPost]
        public async Task<IActionResult> Create(MemberViewModel viewModel)
        {
            Member member = new Member
            {
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                //city se envia null
                // City = new City  
                //{
                //   Id = viewModel.CityId
                //},
                BirthDay = viewModel.BirthDay,
                AllowNewsletter = viewModel.AllowNewsletter
            };

            await _membersAppServices.AddMemberAsync(member);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Member member)
        {
            await _membersAppServices.EditMemberAsync(member);

            return RedirectToAction("Index");
        }
        public IActionResult Test()
        {
            return View();
        }

    }
}
