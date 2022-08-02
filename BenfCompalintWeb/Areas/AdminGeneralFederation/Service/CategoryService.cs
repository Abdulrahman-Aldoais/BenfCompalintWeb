using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.CompalintInformation;
using BenfCompalintWeb.Models.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminGeneralFederation.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly AppCompalintsContextDB _context;

        public CategoryService(AppCompalintsContextDB context) 
        {
            _context = context;
        }


        public async Task<IEnumerable<TypeComplaint>> GetAllGetCompAsync() => await _context.TypeComplaints.ToListAsync();
        public async Task<IEnumerable<TypeComplaint>> GetAllGetCommAsync() => await _context.TypeComplaints.ToListAsync();

        public async Task<TypeComplaint> GetByIdAsync(int id) => await _context.Set<TypeComplaint>().FirstOrDefaultAsync(n => n.Id == id);

        public async Task AddCategoruComm(TypeComplaint entity)
        {
            await _context.TypeComplaints.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddCategoruComp(TypeComplaint entity)
        {
            await _context.TypeComplaints.AddAsync(entity);
            await _context.SaveChangesAsync();
        }


    }
}
