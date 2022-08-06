using BenfCompalintWeb.Areas.UsersService.Model;
using Microsoft.AspNetCore.Identity;
using System;

namespace BenfCompalintWeb.Models
{
    public class ApplicationUserLogin :IdentityUserLogin<string>
    {
        public virtual ApplicationUser User { get; set; }
        
    }
}
