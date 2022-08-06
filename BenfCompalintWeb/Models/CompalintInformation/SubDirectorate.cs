using BenfCompalintWeb.Areas.UsersService.Model;
using BenfCompalintWeb.Models.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models
{
    public class SubDirectorate
    {

        public SubDirectorate()
        {
            //Id = Guid.NewGuid().ToString();
            Villages = new List<Village>();
            Users = new List<ApplicationUser>();
            Beneficiaries = new List<Beneficiarie>();
            Compalints = new List<Compalint>();
        }

      
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Directorate Directorate { get; set; }
        //RelationShipes noe to many
        public virtual ICollection<Village> Villages { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Beneficiarie> Beneficiaries { get; set; }
        public virtual ICollection<Compalint> Compalints { get; set; }

    }
}
