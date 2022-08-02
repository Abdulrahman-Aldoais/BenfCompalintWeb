using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Areas.AdminService.Service;
using BenfCompalintWeb.Areas.AdminService.ViewModel;
using BenfCompalintWeb.Areas.VillagesUsers.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminSubDirectorate.Controllers
{
    [Area("AdminSubDirectorate")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService userService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            var result = userService.GetAllAsync();
            return View(result);
        }

        public IActionResult Block()
        {
            var result = userService.GetAllUserBlockedAsync();
            return View(result);
        }

        [HttpPost]
        public IActionResult Search(InputSearch input)
        {
            if (ModelState.IsValid)
            {
                var result = userService.Search(input.Term);
                return View(result);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Block(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                var result = await userService.TogelBlockUserAsync(userId);
                if (result.Success)
                {
                    TempData["Succes"] = result.Message;
                }
                else
                {
                    TempData["Error"] = result.Message;
                }
                return RedirectToAction("Index");
            }
            TempData["Error"] = "لم يتم العثور على رقم المستخدم";
            return RedirectToAction("Index");

        }



        public async Task<IActionResult> UsersCounts()
        {
            var totalUsersCount = await userService.UserRegistrationCountAsync();
            var month = DateTime.Today.Month;
            var monthUsersCount = await userService.UserRegistrationCountAsync(month);

            return Json(new { tota = totalUsersCount, month = monthUsersCount });

        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddUser(AdminViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = userVM.FullName,
                    Email = userVM.IdentityNumber,
                    PhoneNumber = userVM.PhoneNumber,

                };
                var result = await userManager.CreateAsync(user, userVM.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "AllUsers");

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(userVM);

        }


    }



}
