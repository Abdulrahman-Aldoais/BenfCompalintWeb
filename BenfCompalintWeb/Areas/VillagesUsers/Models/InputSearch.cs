using System.ComponentModel.DataAnnotations;

namespace BenfCompalintWeb.Areas.VillagesUsers.Models
{
    public class InputSearch
    {
        [MinLength(3)]
        [Required]
        public string Term { get; set; }
    }
}
