using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model.Employee
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Country { get; set; }
    }
}
