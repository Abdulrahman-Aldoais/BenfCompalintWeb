using BenfCompalintWeb.Models.Data.ViewModels;
using BenfCompalintWeb.Models.Benef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Models.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppCompalintsContextDB _context;


        public EntityBaseRepository(AppCompalintsContextDB context)
        {
            _context = context;
        }




        public async Task AddCompAsync(Compalint compalint)
        {
            await _context.Compalints.AddAsync(compalint);
            await _context.SaveChangesAsync();
        }

        public Task DeleteCompalintAsync(string id)
        {
            throw new NotImplementedException();
        }

      

        public Task SelectCascadingDropdwon(T entiry)
        {
            throw new NotImplementedException();
        }

    

        public Task UpdateCompalintAsync(string id, T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();


        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeproperties)
        {
            System.Linq.IQueryable<T> query = _context.Set<T>();
            query = includeproperties.Aggregate(query, (current, includeproperty) => current.Include(includeproperty));
            return await query.ToListAsync();
        }


        //public List<Governorate> GetAllGovernorate()
        //{
        //    var govList = from Governorate in _context.Governorates select Governorate;
        //    var gorName = govList.ToList<Governorate>();

        //    return gorName;
        //}

        //public List<Directorate> GetAllDirectorate(string GoveId)
        //{
        //    var dirList = from Directorate in _context.Directorates where Directorate.Id == GoveId select Directorate;
        //    var ditNames = dirList.ToList<Directorate>();
        //    return ditNames;
        //}

        //public List<SubDirectorate> GetAllSubDirectorate(int DireId)
        //{
        //    var subDirList = from SubDirectorate in _context.SubDirectorates where SubDirectorate.Id == DireId select SubDirectorate;
        //    var subDirectorNames = subDirList.ToList<SubDirectorate>();
        //    return subDirectorNames;
        //}

        //public List<Village> GetAllVillage(int SubDireId)
        //{
        //    var VillageList = from Village in _context.Villages where Village.Id == SubDireId select Village;
        //    var VillageNames = VillageList.ToList<Village>();
        //    return VillageNames;
        //}

        //public async Task AddNewProsalsAsync(NewProposalsVM data )
        //{
        //    var newProposal = new Proposal()
        //    {
        //        TitileProposal = data.TitileProposal,
        //        DescProposal = data.DescProposal,
        //        ContentProposal = data.ContentProposal,
        //    };
        //    await _context.AddAsync(newProposal);
        //    await _context.SaveChangesAsync();
        //}

      

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task AddUser(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Beneficiarie> GetBeneficiarieById(string id)
        {
            var beneficiarieDetails = _context.Beneficiaries
               .Include(s => s.TypeBeneficiaris)
               .Include(g => g.Admin)
               .Include(d => d.Governorate)
               .Include(d => d.Directorate)
               .Include(su => su.SubDirectorate)
               .Include(v => v.Village)
               .FirstOrDefaultAsync(c => c.Id == id);
            return await beneficiarieDetails;
        }



        public async Task<Compalint> GetCompalintById(string id)
        {
            var compalintDetails = _context.Compalints
                .Include(s => s.StatusCompalint)
                .Include(f => f.TypeComplaint)
                .Include(g => g.Governorates)
                .Include(d => d.Directorates)
                .Include(su => su.SubDirectorates)
                .Include(v => v.Villages)
                .Include(st => st.StagesComplaint)
                //.Include(so => so.HoUser.UserName)
                //.Include(cs => cs.Compalints_Solutions)
                //.ThenInclude(a => a.UserAddSolution)
                .FirstOrDefaultAsync(c => c.Id == id);
            //var compalintDetails = from m in _context.Compalints select m;
            return await compalintDetails;
        }




        public async Task<T> GetByIdAsync(string id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);


        public async Task<SelectDataDropdownsVM> GetNewCompalintsDropdownsValues()
        {
            var response = new SelectDataDropdownsVM()
            {

                StatusCompalints = await _context.StatusCompalints.OrderBy(n => n.Name).ToListAsync(),
                TypeComplaints = await _context.TypeComplaints.OrderBy(n => n.Type).ToListAsync(),

            };

            return response;

        }

        // Beneficiarie
        public async Task<IEnumerable<Beneficiarie>> GetAllBenficiareByLocalAsync(params Expression<Func<Beneficiarie, object>>[] includeproperties)
        {
            System.Linq.IQueryable<Beneficiarie> query = _context.Set<Beneficiarie>();
            query = includeproperties.Aggregate(query, (current, includeproperty) => current.Include(includeproperty));
            return await query.ToListAsync();
        }


     

      

        public async Task AddNewSolutionCompalintAsync(string id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(string id)
        {
            var entity = _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(await entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(string id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
