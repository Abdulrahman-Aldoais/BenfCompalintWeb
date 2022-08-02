using AutoMapper;
using AutoMapper.QueryableExtensions;
using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Areas.AdminService.ViewModel;
using BenfCompalintWeb.Areas.VillagesUsers.Models;
using BenfCompalintWeb.Const;
using BenfCompalintWeb.Models;
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
        private readonly RoleManager<IdentityRole> roleManager;

        public UserService(
            AppCompalintsContextDB contex,
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            this.contex = contex;
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
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

        public IQueryable<AdminViewModel> GetAllAsync()
        {
            var result = contex.Users.OrderByDescending(u => u.CreatedDate).ProjectTo<AdminViewModel>(mapper.ConfigurationProvider);
            return result;
        }

        public IQueryable<AdminViewModel> GetAllUserBlockedAsync()
        {
            var result = contex.Users.Where(u => u.IsBlocked).ProjectTo<AdminViewModel>(mapper.ConfigurationProvider);
            return result;
        }

        public IQueryable<AdminViewModel> Search(string term)
        {
            var result = contex.Users.Where(
                u => u.IdentityNumber == term
                || u.UserName == term).ProjectTo<AdminViewModel>(
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
                await roleManager.CreateAsync(new IdentityRole(UserRoles.AdminVillages));
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
    }
}
