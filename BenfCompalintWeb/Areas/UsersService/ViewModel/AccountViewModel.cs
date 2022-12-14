using BenfCompalintWeb.Enums;
using BenfCompalintWeb.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace BenfCompalintWeb.Areas.UsersService.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        //[Timestamp]
        public DateTime DateCreated { get; set; }
        public ApplicationRole Roles { get; set; }

        public int? GovernorateId { get; set; }

        public int? DirectorateId { get; set; }

        public int? SubDirectorateId { get; set; }
        //[ForeignKey("SubDirectorateId")]

        public int? VillageId { get; set; }
        //[ForeignKey("VillageId")]

        public int SocietyId { get; set; }
        //[ForeignKey("SociId")]

        //public IEnumerable<string> Roles { get; set; }
        public byte[] ProfilePicture { get; set; }
        public bool IsBlocked { get; set; }

        public DateTime CreatedDate { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }

}
