using BenfCompalintWeb.Models.CompalintInformation;
using System.Collections.Generic;

namespace BenfCompalintWeb.Models.Data.ViewModels
{
    public class SelectDataDropdownsVM
    {
        //SelectDataDropdownsForNewCompalintVM
        public SelectDataDropdownsVM()
        {
        
            TypeComplaints = new List<TypeComplaint>();
            StatusCompalints = new List<StatusCompalint>();


        }

        //public int ID { get; set; }
      
      
        public List<TypeComplaint> TypeComplaints { get; set;}
        public List<StatusCompalint> StatusCompalints { get; set; }
    }
}
