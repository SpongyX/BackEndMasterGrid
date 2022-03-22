using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model.Company
{
    public class NewCompanyModel
    {
       // public int UserCode { get; set; }
        public string Description { get; set; }
        public string AddedFuelQty { get; set; }
        public string FuelQty { get; set; }
        public DateTime? AddedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
