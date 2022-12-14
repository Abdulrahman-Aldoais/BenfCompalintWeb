using AutoMapper;
using AutoMapper.QueryableExtensions;
using BenfCompalintWeb.Areas.UsersService.Model;
using BenfCompalintWeb.Areas.UsersService.ViewModel;
using BenfCompalintWeb.Areas.VillagesUsers.Models;
using BenfCompalintWeb.Const;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminService.Service
{
    public class UserService : IUserService
    {
        private readonly AppCompalintsContextDB contex;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly AppCompalintsContextDB context;

        public UserService(
            AppCompalintsContextDB contex,
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            AppCompalintsContextDB _context
            )
        {
            this.contex = contex;
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
            context = _context;
        }
        public async Task<OperationResult> TogelBlockUserAsync(string UserId)
        {
            var existedUser = await contex.Users.FindAsync(UserId);
            if (existedUser == null)
            {
                return OperationResult.NotFond();
            }
            existedUser.IsBlocked = !existedUser.IsBlocked;
            contex.Update(existedUser);
            await contex.SaveChangesAsync();
            return OperationResult.Successeded();
        }

        public IQueryable<ApplicationUser> GetAllAsync()
        {
            var result = contex.Users.Include(c=>c.UserRoles).OrderByDescending(u => u.CreatedDate);
            //.ProjectTo<ApplicationUser>(mapper.ConfigurationProvider)
            return result;
        }

        public IQueryable<ApplicationUser> GetAllUserBlockedAsync()
        {
            var result = contex.Users.Include(c => c.UserRoles).Where(u => u.IsBlocked).ProjectTo<ApplicationUser>(mapper.ConfigurationProvider);
            return result;
        }

        public IQueryable<AdminUserViewModel> Search(string term)
        {
            var result = contex.Users.Where(
                u => u.IdentityNumber == term
                || u.UserName == term).ProjectTo<AdminUserViewModel>(
                mapper.ConfigurationProvider);
            return result;
        }

        public async Task<int> UserRegistrationCountAsync()
        {
            var count = await contex.Users.CountAsync();
            return count;
        }

        public async Task<int> UserRegistrationCountAsync(int month)
        {
            var year = DateTime.Today.Year;
            var count = await contex.Users.CountAsync(u => u.CreatedDate.Month == month && u.CreatedDate.Year == year);
            return count;
        }

        //UserRoles.AdminGovernorate,
        //       UserRoles.AdminSubDirectorate,
        //       UserRoles.AdminDirectorate
        public async Task InitializeAsync()
        {
            if (!await roleManager.RoleExistsAsync(
                UserRoles.AdminVillages))
            {
                await roleManager.CreateAsync(new ApplicationRole(UserRoles.AdminVillages));
            }
            var IdentityNamber = "00111100";
            var userName = "abdulrahman";
            var PhoneNumber = "775115810";
            var firstname = "عبدالرحمن";
            var lastName = "علي سرحان الدعيس";

            if (await userManager.FindByEmailAsync(IdentityNamber) == null)
            {
                var user = new ApplicationUser
                {
                    Email = IdentityNamber,
                    UserName = userName,
                    PhoneNumber = PhoneNumber,
                    FirstName = firstname,
                    LastName = lastName,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,

                };
                await userManager.CreateAsync(user, "P@ww11");
                await userManager.AddToRoleAsync(user, UserRoles.AdminGeneralFederation);

            }
        }

        public async Task ChaingeStatusAsync(string id, bool isBlocked)
        {
            var selectedItem = await contex.Users.FindAsync(id);
            if(selectedItem != null)
            {
                selectedItem.IsBlocked = isBlocked;
                contex.Update(selectedItem);
                await contex.SaveChangesAsync();
            }
        }
    }
}


//public class GroupedUserViewModel
//{
//    public List<UserViewModel> Users { get; set; }
//    public List<UserViewModel> Admins { get; set; }
//}
//public class UserViewModel
//{
//    public string Username { get; set; }
//    public string Roles { get; set; }
//}



//public ActionResult Index()
//{
//    var allusers = context.Users.ToList();
//    var users = allusers.Where(x => x.Roles.Select(role => role.Name).Contains("User")).ToList();
//    var userVM = users.Select(user => new UserViewModel { Username = user.FullName, Roles = string.Join(",", user.Roles.Select(role => role.Name)) }).ToList();
//    var admins = allusers.Where(x => x.Roles.Select(role => role.Name).Contains("Admin")).ToList();
//    var adminsVM = admins.Select(user => new UserViewModel { Username = user.FullName, Roles = string.Join(",", user.Roles.Select(role => role.Name)) }).ToList();
//    var model = new GroupedUserViewModel { Users = userVM, Admins = adminsVM };
//    return View(model);
//}

//@model Models.GroupedUserViewModel
// @{
//    ViewBag.Title = "Index";
//}
// < div >
//     @foreach(var user in Model.Admins)
//     {
//         < p >
//             < strong > @user.Username | @user.Roles </ strong >
//         </ p >
//     }
//@foreach(var user in Model.Users)
//     {
//         < p >
//             < strong > @user.Username | @user.Roles </ strong >
//         </ p >
//     }
// </ div >