using BenfCompalintWeb.Models.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenfCompalintWeb.Models.CompalintInformation
{
    public class StagesComplaint
    {
        //public StagesComplaint()
        //{
        //    Id = Guid.NewGuid().ToString();
        //}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Compalint> Compalints { get; set; }

    }
}
