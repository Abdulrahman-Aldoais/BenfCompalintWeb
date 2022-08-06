using BenfCompalintWeb.Areas.UsersService.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models
{
    public partial class Governorate
    {
        public Governorate()
        {
            //Id = Guid.NewGuid().ToString();
            Directorates = new List<Directorate>();
            Users = new List<ApplicationUser>();
            Beneficiaries = new List<Beneficiarie>();
            Compalints = new List<Compalint>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        //RelationShipes noe to many
        public virtual ICollection<Directorate> Directorates { get; set; }
        //public virtual List<User> Users { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Compalint> Compalints { get; set; }
        public virtual ICollection<Beneficiarie> Beneficiaries { get; set; }


    }
}
