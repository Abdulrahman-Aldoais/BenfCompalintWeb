using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.Data.Base;
using BenfCompalintWeb.Models.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.VillagesUsers.Service
{
    public interface IVillageService : IEntityBaseRepository<Compalint>
    {




        //Task<IEnumerable<Compalint>> GetAllCompalintsAsync();
        Task<IEnumerable<Compalint>> GetAllCompalintsByLocalAsync(params Expression<Func<Compalint, object>>[] includeproperties);

        Task DeleteAsync(int id, int userId);

        Task IncreamentComplaintSolutionsCount(int id);

        Task<int> GetComplaintSolutionsCount();

    }
}
