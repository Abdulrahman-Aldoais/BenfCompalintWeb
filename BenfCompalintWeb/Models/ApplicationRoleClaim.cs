using Microsoft.AspNetCore.Identity;
using System;

namespace BenfCompalintWeb.Models
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}