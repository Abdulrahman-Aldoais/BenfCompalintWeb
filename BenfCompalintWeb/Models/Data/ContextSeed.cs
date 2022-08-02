using BenfCompalintWeb.Areas.AdminService.Model;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Models.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Beneficiarie.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Governorate.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Directorate.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Villages.ToString()));
        }
        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "abdulrahman",
                IdentityNumber = "0001111000",
                
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Beneficiarie.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Governorate.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Directorate.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Villages.ToString());
                }

            }
        }
    }
}
