using BenfCompalintWeb.Models.CompalintInformation;
using BenfCompalintWeb.Models.Data.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminGeneralFederation.Service
{
    public interface ICategoryService 
    {
        Task AddCategoruComp(TypeComplaint entity);
        Task AddCategoruComm(TypeComplaint entity);
        Task<IEnumerable<TypeComplaint>> GetAllGetCompAsync();
        Task<IEnumerable<TypeComplaint>> GetAllGetCommAsync();


    }
}
