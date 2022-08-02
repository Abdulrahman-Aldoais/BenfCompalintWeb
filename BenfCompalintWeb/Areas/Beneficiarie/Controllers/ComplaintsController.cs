using BenfCompalintWeb.Areas.Beneficiarie.Service;
using BenfCompalintWeb.Areas.Beneficiarie.ViewModels;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.CompalintInformation;
using BenfCompalintWeb.Models.Data.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BenfCompalintWeb.Areas.Beneficiarie.Controllers
{
    [Area("Beneficiarie")]

    public class ComplaintsController : Controller
    {
        private readonly ILocationRepo<Governorate> governorate;
        private readonly ILocationRepo<Directorate> directorate;
        private readonly ILocationRepo<SubDirectorate> subDirectorate;
        private readonly ILocationRepo<Village> village;

        private readonly IWebHostEnvironment _env;


        private readonly ICompalintService _service;
        private readonly AppCompalintsContextDB _context;

        public ComplaintsController(
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


        //[HttpPost]
        //public async Task<IActionResult> GetCustomers()
        //{
        //    var pageSize = int.Parse(Request.Form["length"]);
        //    var skip = int.Parse(Request.Form["start"]);

        //    var searchValue = Request.Form["search[value]"];

        //    var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
        //    var sortColumnDirection = Request.Form["order[0][dir]"];

        //    IQueryable<Compalint> complaints = _context.Compalints.Where(m => string.IsNullOrEmpty(searchValue)
        //        ? true
        //        : (m.TitleComplaint.Contains(searchValue) || m.DescComplaint.Contains(searchValue) || m.Beneficiaries.Name.Contains(searchValue) || m.DescComplaint.Contains(searchValue)));

        //    if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)));
        //    //customers = customers.OrderBy(string.Concat(sortColumn, " ", sortColumnDirection));


        //    var data = complaints.Skip(skip).Take(pageSize).ToList();

        //    var recordsTotal = complaints.Count();

        //    var jsonData = new { recordsFiltered = recordsTotal, recordsTotal, data };

        //    return Ok(jsonData);
        //}


        public async Task<IActionResult> Index(int? page)
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





        //public async Task<IActionResult> Index(int? page)
        //{
        //    var compalintDropdownsData = await _service.GetNewCompalintsDropdownsValues();
        //    //var LocationDropdownsData = await _service.GetSelectLocationDropdownsValues();
        //    ViewBag.StatusCompalints = new SelectList(compalintDropdownsData.StatusCompalints, "Id", "Name");
        //    ViewBag.TypeComplaints = new SelectList(compalintDropdownsData.TypeComplaints, "Id", "Type");

        //    var allCompalintsVewi = await _service.GetAllAsync();
        //    if (page > 0)
        //    {
        //        page = page;
        //    }
        //    else
        //    {
        //        page = 1;
        //    };

        //    int limit = 4;
        //    int start = (int)((int?)(page - 1) * limit);
        //    int totalCompalints = allCompalintsVewi.Count();
        //    ViewBag.TotalCompalints = Convert.ToInt32(page == 0 ? "false" : totalCompalints);
        //    ViewBag.totalCompalints = totalCompalints;
        //    ViewBag.pageCurrent = page;
        //    int numberPage = (totalCompalints / limit);
        //    ViewBag.numberPage = numberPage;
        //    var dataCompalints = allCompalintsVewi.OrderByDescending(s => s.Id).Skip(start).Take(limit);
        //    return View(dataCompalints);



        //}

        public async Task<IActionResult> ViewRejectedComplaints()
        {
            
            var compalintDropdownsData = await _service.GetNewCompalintsDropdownsValues();
            ViewBag.StatusCompalints = new SelectList(compalintDropdownsData.StatusCompalints, "Id", "Name");
            ViewBag.TypeComplaints = new SelectList(compalintDropdownsData.TypeComplaints, "Id", "Type");

             ViewBag.status = ViewBag.StatusCompalints;

            var rejectedComplaints = await _service.GetAllAsync(n=> n.StatusCompalint);
            var result =  rejectedComplaints.Where(n => n.StatusCompalint.Name == "مرفوضة"
            );

            return View(result);

        }



        [HttpGet]
        public JsonResult GetDirectorates(int GovernorateId)
        {
            var g = governorate.Find(GovernorateId);
            var dire = directorate.ListByFilter(cc => cc.Governorate == g);
            return Json(new SelectList(dire, "Id", "Name"));
        }



        //GET: Compalint /Add
        public async Task<IActionResult> AddCompalint()
        {
            NewCompalintVM NcomVM = new NewCompalintVM()
            {
                Governorates = governorate.List(),
            };
            var compalintDropdownsData = await _service.GetNewCompalintsDropdownsValues();

            ViewBag.TypeComplaints = new SelectList(compalintDropdownsData.TypeComplaints, "Id", "Type");
            ViewBag.StatusCompalints = new SelectList(compalintDropdownsData.StatusCompalints, "Id", "Name");

            return View(NcomVM);

        }

        [HttpPost]
        public async Task<IActionResult> AddCompalint(NewCompalintVM data)
        {

            if (ModelState.IsValid)
            {
                var addCompalint = new Compalint()
                {
                    TitleComplaint = data.TitleComplaint,
                    TypeComplaintId = data.TypeComplaintId,
                    DescComplaint = data.DescComplaint,
                    PropBeneficiarie = data.PropBeneficiarie,
                    GovernorateId = data.GovernorateId,
                    DirectorateId = data.DirectorateId,
                    SubDirectorateId = data.SubDirectorateId,
                    VillageId = data.VillageId,
                    CompDate = data.CompDate,


                };
            }
            await _service.AddNewCompalintAsync(data);
            return RedirectToAction(nameof(Index));


        }

        private string BeneficiarieId
        {
            get
            {
                return User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
        }

        //public async Task<IActionResult> AddCompalint(InputFile model)
        //{ 
        //    if (ModelState.IsValid)
        //    {
        //        var newName = Guid.NewGuid().ToString(); //rre-rewrwerwer-gwgrg-grgr
        //        var extension = Path.GetExtension(model.File.FileName);
        //        var fileName = string.Concat(newName, extension); // newName + extension
        //        var root = _env.WebRootPath;
        //        var path = Path.Combine(root, "Uploads", fileName);

        //        using (var fs = System.IO.File.Create(path))
        //        {
        //            await model.File.CopyToAsync(fs);
        //        }

        //        await _service.AddNewCompalintAsync(new NewCompalintInputUploadVM
        //        {
        //            OriginalFileName = model.File.FileName,
        //            FileName = fileName,
        //            ContentType = model.File.ContentType,
        //            Size = model.File.Length,
        //            BeneficiarieId = BeneficiarieId,

        //        });

        //        return RedirectToAction("Index");
        //    }
        //    return View(model);


        //}


        //GET Compalint/ViewCompalintDetails/1

        public async Task<IActionResult> ViewCompalintDetails(string id)
        {
            var compalintDetails = await _service.GetCompalintById(id);
            return View(compalintDetails);
        }

        [AllowAnonymous]
        public async Task<IActionResult> RejectedComplaints()
        {
            var allCompalints = await _service.GetAllAsync(n =>n.StatusCompalintId == 2);
            return View(allCompalints);
        }

        [AllowAnonymous]
        public async Task<IActionResult> FilterCompalintsBySearch(string searchString)
        {
            var allCompalints = await _service.GetAllAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                var filtterResulteNew = allCompalints.Where(n => string.Equals(n.TitleComplaint,
                    searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.DescComplaint,
                    searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
                return View("Index", filtterResulteNew);
            }
            //return View("Index", allCompalints);
            return View("Index", allCompalints);
        }

    }
}
