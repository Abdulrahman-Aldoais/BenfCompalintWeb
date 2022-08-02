using BenfCompalintWeb.Areas.Beneficiarie.Service;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.CompalintInformation;
using BenfCompalintWeb.Models.Data.Base;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
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
