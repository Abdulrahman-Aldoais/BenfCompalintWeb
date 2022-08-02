using BenfCompalintWeb.Models.CompalintInformation;
using System;
using System.Collections.Generic;

namespace BenfCompalintWeb.Data.ViewModels
{
    public class UserViewModel
    {

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public int? GovernorateId { get; set; }
        public int? DirectorateId { get; set; }
        public int? SubDirectorateId { get; set; }
        public int? VillageId { get; set; }
        public int SocietyId { get; set; }
        public virtual ICollection<TypeComplaint> TypeComplaints { get; set; }
        public bool IsActivity { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Compalints_Solution> Compalints_Solutions { get; set; }
        public byte[] ProfilePicture { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
