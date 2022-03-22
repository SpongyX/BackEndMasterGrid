using MHGridMasterDetails.Model.Dto;
using MHGridMasterDetails.Model.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Interface
{
  public interface IEmployeeService
    {
        ResponseMessage CreateUser(UserModel model);
        ResponseMessage UpdateUser(UserModel model);
        ResponseMessage GetEmployee();
        ResponseMessage GetEmployeeById(int id);
        ResponseMessage DeleteEmployee(int id);
        ResponseMessage GetGender();
        ResponseMessage GetDepartment();
        ResponseMessage GetLevel();
        ResponseMessage GetCountry();
    }
}
