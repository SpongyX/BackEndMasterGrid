using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model.Dto
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }
        public string Description { get; set; }
        public string AltDescription { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
