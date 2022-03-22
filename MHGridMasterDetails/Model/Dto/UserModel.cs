using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model.Dto
{
    public class UserModel
    {
        public int UserCode { get; set; }
        public string Description { get; set; }
        public int GenderId { get; set; }
        public int DepartmentId { get; set; }
        public int LevelId { get; set; }
        public int CountryId { get; set; }

        //public string AltDescription { get; set; }
        //public bool? IsActive { get; set; }
        //public DateTime? AddedDate { get; set; }
    }
}
