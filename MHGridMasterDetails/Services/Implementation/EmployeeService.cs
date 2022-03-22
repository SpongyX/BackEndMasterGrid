using MHGridMasterDetails.Data;
using MHGridMasterDetails.Model.Dto;
using MHGridMasterDetails.Model.Employee;
using MHGridMasterDetails.Model.ResponseMessage;
using MHGridMasterDetails.Services.Interface;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private GMDsDBContext _gMDsDBContext;
        //private HttpContext _httpContext;
        //private IConfiguration _config;

        public EmployeeService(
      GMDsDBContext gMDsDBContext
            //IHttpContextAccessor httpContextAccessor,
            //IConfiguration config
            )
        {
            _gMDsDBContext = gMDsDBContext;
            //_httpContext = httpContextAccessor.HttpContext;
            //_config = config;
        }

        public ResponseMessage CreateUser(UserModel model)
        {
            var newUser = new User()
            {
                //UserCode = model.UserCode,
                Description = model.Description,
                GenderId = model.GenderId,
                LevelId = model.LevelId,
                DepartmentId = model.DepartmentId,
                CountryId = model.CountryId,
                IsActive = true




                // AltDescription = model.AltDescription,
                // IsActive = true,
                // AddedDate = DateTime.Now,
            };
            this._gMDsDBContext.User.Add(newUser);
            this._gMDsDBContext.SaveChanges();
            return ResponseMessage.PerformSuccess();
        }

        public ResponseMessage DeleteEmployee(int id)
        {
            try
            {
               // int loginUserId = this._httpContext.GetCurrentUserId().ToIntOrDefault();
                var userObject = this._gMDsDBContext.User.Where(r => r.UserCode == id).FirstOrDefault();
                if (userObject.IsActive == null)
                {
                    return ResponseMessage.PerformError("Product already deleted");
                }
                userObject.IsActive = false;
                //productObject.LastEdited = DateTime.Now;
                //productObject.LastEditedBy = loginUserId;
               // _gMDsDBContext.User.Remove(userObject);
                this._gMDsDBContext.SaveChanges();
                return ResponseMessage.PerformSuccess();
            }
            catch (Exception ex)
            {
               // HelperContext.Log("DeleteProduct", "ProductService", "--", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError(ex.Message);
            }
        }

        public ResponseMessage GetCountry()
        {
            try
            {
                var model =
                    this._gMDsDBContext.Countries
                    .ToList();
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                //HelperContext.Log("GetPackages", "ProjectInfoService", "GetPackages", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError(ex.Message);
            }
        }

        public ResponseMessage GetDepartment()
        {
            try
            {
                var model =
                    this._gMDsDBContext.Department
                    .ToList();
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                //HelperContext.Log("GetPackages", "ProjectInfoService", "GetPackages", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError(ex.Message);
            }
        }

        public ResponseMessage GetEmployee()
        {
            try
            {
                //var model = _gMDsDBContext.User.ToList();
                var model = (from u in _gMDsDBContext.User
                             join g in _gMDsDBContext.Gender
                             on u.GenderId equals g.GenderId
                             join d in _gMDsDBContext.Department
                             on u.DepartmentId equals d.DepartmentId
                             join l in _gMDsDBContext.Level
                             on u.LevelId equals l.LevelId
                             join c in _gMDsDBContext.Countries
                             on u.CountryId equals c.CountryId
                             where u.IsActive == true
                             select new EmployeeModel
                             {
                                 Id = u.UserCode,
                                 UserName = u.Description,
                                 Gender = g.Description,
                                 Department = d.Description,
                                 Position = l.Description,
                                 Country = c.Description
                             });
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                //HelperContext.Log("GetEmployee", "EmployeeService", "GetEmployee", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                //return ResponseMessage.PerformError(ErrorCodes.Exception.ToString(), ex.Message);
                return ResponseMessage.PerformError(ex.Message);
            }
        }

        public ResponseMessage GetEmployeeById(int id)
        {
            try
            {
                var userObject = this._gMDsDBContext.User.Where(r => r.UserCode == id).FirstOrDefault();
                if (userObject.IsActive == null)
                {
                    return ResponseMessage.PerformError("User Not Exist");
                }
                return ResponseMessage.PerformSuccess(userObject);
            }
            catch (Exception ex)
            {
                return ResponseMessage.PerformError(ex.Message);
            }
        }

        public ResponseMessage GetGender()
        {
            try
            {
                var model =
                    this._gMDsDBContext.Gender
                    .ToList();
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                //HelperContext.Log("GetPackages", "ProjectInfoService", "GetPackages", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError(ex.Message);
            }
        }

        public ResponseMessage GetLevel()
        {
            try
            {
                var model = this._gMDsDBContext.Level.ToList();
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
               // HelperContext.Log("GetMilestone", "ProjectInfoService", "GetMilestone", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError( ex.Message);
            }
        }

        public ResponseMessage UpdateUser(UserModel model)
        {
            try
            {
                 var userObject = this._gMDsDBContext.User.Where(r => r.UserCode == model.UserCode).FirstOrDefault();
               // var userObject = this._gMDsDBContext.User.FirstOrDefault();

                //userObject.UserCode = model.UserCode;
                userObject.Description = model.Description;
                userObject.GenderId = model.GenderId;
                userObject.DepartmentId = model.DepartmentId;
                userObject.LevelId = model.LevelId;
                userObject.CountryId = model.CountryId;
                
          

                // AltDescription = model.AltDescription,
                // IsActive = true,
                // AddedDate = DateTime.Now,

                this._gMDsDBContext.SaveChanges();
                return ResponseMessage.PerformSuccess();
            }
            catch (Exception ex)
            {
                return ResponseMessage.PerformError(ex.Message);
            }
        }
    }
}
