using BenfCompalintWeb.Areas.AdminGeneralFederation.Service;
using BenfCompalintWeb.Const;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.CompalintInformation;
using BenfCompalintWeb.Models.Data.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminGeneralFederation.Controllers
{
    [Area("AdminGeneralFederation")]
    //[Route("AdminGeneralFederation/[Controller]/[Action]/{id?}")]
    //[Authorize(Roles = UserRoles.AdminGeneralFederation)]
    public class ManageCategoryesController : Controller
    {

        private readonly AppCompalintsContextDB _context;
        private readonly ICategoryService _service;

        //private readonly ICategoryService _service;

        public ManageCategoryesController(AppCompalintsContextDB context , ICategoryService service )
        {
            _context = context;
            _service = service;
        }




        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllCategoriesCommunications()
        {
            var allCatCommunications = await _service.GetAllGetCommAsync();

            return View(allCatCommunications);
        }

        
        public IActionResult Circulars()
        {
            return View();
        }
        public async Task<IActionResult> AllCategoriesComplaints()
        {
            var allCategoriesComplaints = await _service.GetAllGetCompAsync();

            return View(allCategoriesComplaints);
        }
        [HttpGet]
        public async Task<IActionResult> AddCategory()
        {
            return View();
        }



        //[HttpPost]
        //public async Task<IActionResult> AddCategory([Bind("Id,Type")] TypeComplaint type)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return View(type);
        //    }
        //    await _service.AddAsync(type);
        //    return RedirectToAction(nameof(Index));
        //}

        //GET Movie/Edit/1
        //public async Task<IActionResult> Edit(Guid id)
        //{

        //    var CateDetails = await _service.GetByIdAsync(id);
        //    if (CateDetails == null) return View("Empty");

        //    return View(CateDetails);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id,Type")] TypeComplaint type)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return View(type);
        //    }
        //    await _service.UpdateAsync(id, type);
        //    return RedirectToAction(nameof(Index));
        //}


    }
}
