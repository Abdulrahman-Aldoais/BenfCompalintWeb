using BenfCompalintWeb.Areas.UsersService.Model;
using Microsoft.AspNetCore.Identity;
using System;

namespace BenfCompalintWeb.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
{
    public virtual ApplicationUser User { get; set; }
    public virtual ApplicationRole Role { get; set; }
}
}
