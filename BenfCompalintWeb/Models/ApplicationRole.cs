using BenfCompalintWeb.Areas.UsersService.Model;
using BenfCompalintWeb.Models.Data.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole(string roleName) : base(roleName)
        {
        }

        //public ApplicationRole(string roleName) : base(roleName)
        //{
        //}

        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
