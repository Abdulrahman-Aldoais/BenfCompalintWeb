using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Areas.UsersService.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Controllers
{
    public class AccountController : Controller
    {
        //private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly UserManager<IdentityUser> _userManager;

        //public AccountController(SignInManager<IdentityUser>signInManager,UserManager<IdentityUser>userManager )
        //{
        //    _signInManager = signInManager;
        //    _userManager = userManager;
        //}


        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
              var result = await _signInManager.PasswordSignInAsync(model.IdentityNumber, model.Password,true,true);
                if (result.Succeeded)
                {
                  return RedirectToAction("Complaints","Index");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Regster()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Regster(RegisterViewModel models)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = models.IdentityNumber,
                    Email = models.IdentityNumber,
                    PhoneNumber = models.PhoneNumber,
                    
                };
                  var result = await _userManager.CreateAsync(user, models.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction("Complaints", "Index");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(" ", error.Description);
                }
            }
            return View();
        }

    }
}
