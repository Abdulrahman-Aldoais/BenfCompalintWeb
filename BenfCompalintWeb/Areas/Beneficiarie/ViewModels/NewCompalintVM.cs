using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Models;
using BenfCompalintWeb.Models.CompalintInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace BenfCompalintWeb.Areas.Beneficiarie.ViewModels
{
    public class NewCompalintVM
    {


        public Guid Id { get; set; }
        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public string TitleComplaint { get; set; }

        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public int TypeComplaintId { get; set; }


        [Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public string DescComplaint { get; set; }

        public int? SocietyId { get; set; }

        public int StatusCompalintId { get; set; } = 1;

        //RelationShipes one to many with Compalints and StatusCompalint

        //RelationShipes one to many with Compalints and StagesComplaint

        public int StagesComplaintId { get; set; } = 1;

        //[Required(ErrorMessage = "يجب ان تقوم بكتابة هذه الحقل ")]
        public string PropBeneficiarie { get; set; }
        //RelationShipes one to many with Compalints and Village


        public List<Governorate> Governorates { get; set; }
        public int GovernorateId { get; set; }

        public int? DirectorateId { get; set; }


        ////RelationShipes one to many with Compalints and Village
        //[Required(ErrorMessage = "يجب ان تقوم بإختبار المنطقة المحددة ")]
        public int? SubDirectorateId { get; set; }


        //RelationShipes one to many with Compalints and Village
        //[Required(ErrorMessage = "يجب ان تقوم بإختبار المنطقة المحددة ")]
        public int? VillageId { get; set; }
        //[ForeignKey("VillageId")]



        public DateTime CompDate { get; set; }
        //[Timestamp]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime CompDateUp { get; set; }
        public virtual ICollection<Compalints_Solution> Compalints_Solutions { get; set; }

        //public string BeneficiarieId { get; set; } 
        //[ForeignKey("BeneficiariesId")]
        public virtual ApplicationUser HoUser { get; set; }


    }
}
