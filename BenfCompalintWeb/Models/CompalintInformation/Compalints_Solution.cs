using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Models.Data.Base;
using System;


namespace BenfCompalintWeb.Models.CompalintInformation
{
    public class Compalints_Solution : IEntityBase
    {
        public Compalints_Solution()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public int? UserId { get; set; }
        public virtual ApplicationUser UserAddSolution { get; set; }
        public int CompalintId { get; set; }
        public virtual Compalint CompalintsHasSolution { get; set; }
        public int? BeneficiarieId { get; set; }
        public virtual Beneficiarie Beneficiaries { get; set; }
        public string ContentSolution { get; set; } = "";
        public DateTime DateSolution { get; set; } = DateTime.Now;

    }
}
