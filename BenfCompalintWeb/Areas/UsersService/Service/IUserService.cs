using BenfCompalintWeb.Areas.UsersService.Model;
using BenfCompalintWeb.Areas.UsersService.ViewModel;
using BenfCompalintWeb.Areas.VillagesUsers.Models;
using BenfCompalintWeb.Models.Data.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminService.Service
{
    public interface IUserService
    {
        IQueryable<ApplicationUser> GetAllAsync();
        IQueryable<ApplicationUser> GetAllUserBlockedAsync();
        IQueryable<AdminUserViewModel> Search(string term);
        Task<OperationResult> TogelBlockUserAsync(string UserId);
        Task<int> UserRegistrationCountAsync();
        Task ChaingeStatusAsync(string id, bool status);
        Task<int> UserRegistrationCountAsync(int month);
        //Task<SelectDataDropdownsVM> GetNewCompalintsDropdownsValues();
        Task InitializeAsync();
    }
}
