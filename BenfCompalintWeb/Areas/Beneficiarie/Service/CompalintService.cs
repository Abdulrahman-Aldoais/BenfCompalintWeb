using AutoMapper;
using BenfCompalintWeb.Areas.Beneficiarie.ViewModels;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.Data.Base;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.Beneficiarie.Service
{
    public class CompalintService : EntityBaseRepository<Compalint>, ICompalintService
    {
        private readonly AppCompalintsContextDB _context;
        private readonly IMapper _mapper;
        public CompalintService(AppCompalintsContextDB context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }



        public async Task AddNewCompalintAsync(NewCompalintVM data)
        {


            var addCompalintmappedObj = new Compalint()
            {
                TitleComplaint = data.TitleComplaint,
                TypeComplaintId = data.TypeComplaintId,
                DescComplaint = data.DescComplaint,
                PropBeneficiarie = data.PropBeneficiarie,
                GovernorateId = data.GovernorateId,
                DirectorateId = data.DirectorateId,
                SubDirectorateId = data.SubDirectorateId,
                VillageId = data.VillageId,
                StagesComplaintId= data.StagesComplaintId = 1,

            };


            await _context.AddAsync(addCompalintmappedObj);
            await _context.SaveChangesAsync();
            //foreach (var actorId in data.ActorIds)
            //{

            //    var newActorMovie = new Actors_Movie()
            //    {
            //        MovieId = newMovie.Id,
            //        ActorId = actorId,
            //    };
            //    await _context.Actors_Movies.AddAsync(newActorMovie);
            //}
            await _context.SaveChangesAsync();


        }






        //public async Task<SelectLocationDropdownsVM> GetSelectLocationDropdownsValues()
        //{
        //    var responseLoc = new SelectLocationDropdownsVM()
        //    {
        //        Governorates = await _context.Governorates.OrderBy(n => n.Name).ToListAsync(),
        //        Directorates = await _context.Directorates.OrderBy(n => n.Name).ToListAsync(),
        //        SubDirectorates = await _context.SubDirectorates.OrderBy(n => n.Name).ToListAsync(),
        //        Villages = await _context.Villages.OrderBy(n => n.Name).ToListAsync(),

        //    };

        //    return responseLoc;

        //}


        //public IQueryable<Compalint> GetAllAsyncByStutas(int Pnumber, int Psize)
        //{
        //    var compList = _context.Compalints.AsNoTracking().Skip(Pnumber * Psize - Psize).Take(Psize).ToList();
        //    return (IQueryable<Compalint>)compList;
        //}

        //public IQueryable<Compalint> GetCompalintsByStutas(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IQueryable<NewCompalintVM> GetBy(string userId)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<NewCompalintVM> FindAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<NewCompalintVM> FindAsync(string id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task IncreamentDownloadCount(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetUploadsCount()
        {
            throw new NotImplementedException();
        }

        public Task IncreamentDownloadCount(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Compalint>> GetAllRejectedComplaints()=> await _context.Compalints.ToListAsync();






        //public async Task<IEnumerable<Compalint>> GetAllAsync(params Expression<Func<Compalint, object>>[] includeproperties)
        //{
        //    IQueryable<Compalint> query = _context.Compalints;
        //    query = includeproperties.Aggregate(query, (current, includeproperty) => current.Include(includeproperty));
        //    return await query.ToListAsync();
        //}



        //public async Task CreateAsync(InputUpload model)
        //{
        //    var mappedObj = _mapper.Map<Uploads>(model);
        //    await _context.Uploads.AddAsync(mappedObj);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(string id, string userId)
        //{
        //    var selectedUpload = await _context.Uploads.FirstOrDefaultAsync(u => u.Id == id && u.UserId == userId);
        //    if (selectedUpload != null)
        //    {
        //        _db.Uploads.Remove(selectedUpload);
        //        await _db.SaveChangesAsync();
        //    }
        //}

        //public async Task<UploadViewModel> FindAsync(string id, string userId)
        //{
        //    var selectedUpload = await _db.Uploads.FirstOrDefaultAsync(u => u.Id == id && u.UserId == userId);
        //    if (selectedUpload != null)
        //    {
        //        //AutoMapper 
        //        return _mapper.Map<UploadViewModel>(selectedUpload);
        //    }
        //    return null;
        //}

        //public async Task<UploadViewModel> FindAsync(string id)
        //{
        //    var selectedUpload = await _db.Uploads.FindAsync(id);
        //    if (selectedUpload != null)
        //    {
        //        //AutoMapper 
        //        return _mapper.Map<UploadViewModel>(selectedUpload);
        //    }
        //    return null;
        //}

        //public IQueryable<UploadViewModel> GetAll()
        //{
        //    var result = _db.Uploads
        //         .OrderByDescending(u => u.DownloadCount)
        //         .ProjectTo<UploadViewModel>(_mapper.ConfigurationProvider);
        //    return result;
        //}

        //public IQueryable<UploadViewModel> GetBy(string userId)
        //{
        //    var result = _db.Uploads.Where(u => u.UserId == userId)
        //        .OrderByDescending(u => u.UploadDate)
        //       .ProjectTo<UploadViewModel>(_mapper.ConfigurationProvider);
        //    return result;
        //}

        //public async Task<int> GetUploadsCount()
        //{
        //    return await _db.Uploads.CountAsync();
        //}

        //public async Task IncreamentDownloadCount(string id)
        //{
        //    var selectedUpload = await _db.Uploads.FindAsync(id);
        //    if (selectedUpload != null)
        //    {
        //        selectedUpload.DownloadCount++;

        //        _db.Update(selectedUpload);
        //        await _db.SaveChangesAsync();
        //    }
        //}

        //public IQueryable<UploadViewModel> Search(string term)
        //{
        //    var result = _db.Uploads
        //          .Where(u => u.OriginalFileName.Contains(term))
        //          .OrderByDescending(u => u.DownloadCount)
        //          .ProjectTo<UploadViewModel>(_mapper.ConfigurationProvider);
        //    return result;
        //}




        //public Task<SelectLocationDropdownsVM> GetSelectLocationDropdownsValues()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
