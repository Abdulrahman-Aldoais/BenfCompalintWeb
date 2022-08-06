using BenfCompalintWeb.Areas.UsersService.Model;
using BenfCompalintWeb.Models.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models
{
    public class Village
    {
        public Village()
        {
            //Id = Guid.NewGuid().ToString();
            Compalints = new List<Compalint>();
            Users = new List<ApplicationUser>();
            Beneficiaries = new List<Beneficiarie>();
            Compalints = new List<Compalint>();
        }
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual SubDirectorate SubDirectorate { get; set; }
        public virtual ICollection<Compalint> Compalints { get; set; }
        public virtual ICollection<Beneficiarie> Beneficiaries { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }


        //public virtual List<User> Users { get; set; }

    }
}
