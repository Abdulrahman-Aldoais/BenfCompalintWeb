using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Models.Data.Base;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models.CompalintInformation
{
    public class TypeComplaint
    {
        //public TypeComplaint()
        //{
        //    Id = Guid.NewGuid().ToString();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Type { get; set; }
        //public int? UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ApplicationUser UsersAddType { get; set; }
        public virtual ICollection<Compalint> Compalints { get; set; }

    }
}
