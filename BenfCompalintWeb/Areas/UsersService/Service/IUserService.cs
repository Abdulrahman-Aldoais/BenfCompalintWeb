using BenfCompalintWeb.Areas.AdminService.ViewModel;
using BenfCompalintWeb.Areas.VillagesUsers.Models;
using System.Linq;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminService.Service
{
    public interface IUserService
    {
        IQueryable<AdminViewModel> GetAllAsync();
        IQueryable<AdminViewModel> GetAllUserBlockedAsync();
        IQueryable<AdminViewModel> Search(string term);
        Task<OperationResult> TogelBlockUserAsync(string UserId);
        Task<int> UserRegistrationCountAsync();
        Task<int> UserRegistrationCountAsync(int month);
        Task InitializeAsync();
    }
}
