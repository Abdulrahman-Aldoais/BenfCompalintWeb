using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Models.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models
{
    public class Permission:IEntityBase
    {
        public Permission()
        {
            this.Users = new List<ApplicationUser>();
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string permissionsName { get; set; }
      
        public virtual ICollection<ApplicationUser> Users { get; set; }

    }
}
