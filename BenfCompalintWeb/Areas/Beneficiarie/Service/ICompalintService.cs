﻿using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.Data.Base;
using BenfCompalintWeb.Data.ViewModels;

using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace BenfCompalintWeb.Areas.Beneficiarie.Service
{
    public interface ICompalintService : IEntityBaseRepository<Compalint>
    {


        Task<IEnumerable<Compalint>> GetAllRejectedComplaints();
        Task AddNewCompalintAsync(NewCompalintVM data);

        //Task CreateAsync(InputUpload model);

        Task<NewCompalintVM> FindAsync(string id);
       
        Task<NewCompalintVM> FindAsync(string id, string userId);

        Task DeleteAsync(string id, string userId);

        Task IncreamentDownloadCount(string id);

        Task<int> GetUploadsCount();




    }
}
