using MHGridMasterDetails.Model.Dto;
using MHGridMasterDetails.Model.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Interface
{
   public  interface IUserDetails
    {
        ResponseMessage CreateDepartment (DepartmentModel model);

    }
}
