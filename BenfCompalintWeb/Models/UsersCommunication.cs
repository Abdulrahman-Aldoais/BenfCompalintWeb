using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Models.Data.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models
{
    public class UsersCommunication:IEntityBase
    {
        public UsersCommunication()
        {
            Id = Guid.NewGuid().ToString();
        }
       
        public string Id { get; set; } 
        public int UserId { get; set; }
        public virtual ApplicationUser UsersHas { get; set; }
        public string Titile { get; set; }
        public string reason { get; set; }
    }
}