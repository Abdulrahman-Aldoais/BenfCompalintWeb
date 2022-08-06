using BenfCompalintWeb.Areas.Beneficiarie.Service;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.CompalintInformation;
using BenfCompalintWeb.Models.Data.Base;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.AdminGeneralFederation.Controllers
{
    [Area("AdminGeneralFederation")]
    public class ContentManagementsGeneralFederationController : Controller
    {
        private readonly ILocationRepo<Governorate> governorate;
        private readonly ILocationRepo<Directorate> directorate;
        private readonly ILocationRepo<SubDirectorate> subDirectorate;
        private readonly ILocationRepo<Village> village;

        private readonly IWebHostEnvironment _env;


        private readonly ICompalintService _service;
        private readonly AppCompalintsContextDB _context;

        public ContentManagementsGeneralFederationController(
            ILocationRepo<Governorate> governorate,
            ILocationRepo<Directorate> directorate,
            ILocationRepo<SubDirectorate> subDirectorate,
            ILocationRepo<Village> village,
            ICompalintService service,
            IWebHostEnvironment env,
            AppCompalintsContextDB context)
        {
            this.governorate = governorate;
            this.directorate = directorate;
            this.subDirectorate = subDirectorate;
            this.village = village;
            _service = service;
            _context = context;
            _env = env;
        }
        

        public async Task<IActionResult> ReportManagement()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> AllComplaints(int? page)
        {
            var compalintDropdownsData = await _service.GetNewCompalintsDropdownsValues();
            //var LocationDropdownsData = await _service.GetSelectLocationDropdownsValues();
            var allCompalintsVewi = await _service.GetAllAsync();
            ViewBag.StatusCompalints = new SelectList(compalintDropdownsData.StatusCompalints, "Id", "Name");
            ViewBag.TypeComplaints = new SelectList(compalintDropdownsData.TypeComplaints, "Id", "Type");
            ViewBag.Status = ViewBag.StatusCompalints;
            int totalCompalints = allCompalintsVewi.Count();
            ViewBag.TotalCompalints = Convert.ToInt32(page == 0 ? "false" : totalCompalints);
            ViewBag.totalCompalints = totalCompalints;

            return View(allCompalintsVewi);
        }




        public async Task<IActionResult> ViewRejectedComplaints()
        {

            var compalintDropdownsData = await _service.GetNewCompalintsDropdownsValues();
            ViewBag.StatusCompalints = new SelectList(compalintDropdownsData.StatusCompalints, "Id", "Name");
            ViewBag.TypeComplaints = new SelectList(compalintDropdownsData.TypeComplaints, "Id", "Type");

            ViewBag.status = ViewBag.StatusCompalints;

            var rejectedComplaints = await _service.GetAllAsync(n => n.StatusCompalint);
            var result = rejectedComplaints.Where(n => n.StatusCompalint.Name == "مرفوضة"
            );

            return View(result);

        }

        public async Task<IActionResult> AllCategoriesCommunications()
        {

            return View();
        }

        public async Task<IActionResult> AllCategoriesComplaints()
        {
            var allCategoriesComplaints = await _service.GetAllAsync();

            return View(allCategoriesComplaints);
        }
        [HttpGet]
        public async Task<IActionResult> AddCategory()
        {
            return View();
        }

    }
}
