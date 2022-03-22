using MHGridMasterDetails.Data;
using MHGridMasterDetails.Model.Dto;
using MHGridMasterDetails.Model.ResponseMessage;
using MHGridMasterDetails.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Implementation
{
    public class UserDetailsService : IUserDetails
    {
        private GMDsDBContext _gMDsDBContext;
        //private HttpContext _httpContext;
        //private IConfiguration _config;

        public UserDetailsService(
      GMDsDBContext gMDsDBContext
            //IHttpContextAccessor httpContextAccessor,
            //IConfiguration config
            )
        {
            _gMDsDBContext = gMDsDBContext;
            //_httpContext = httpContextAccessor.HttpContext;
            //_config = config;
        }
        public ResponseMessage CreateDepartment(DepartmentModel model)
        {
            var newDepartment = new Department()
            {
                DepartmentId = model.DepartmentId,
                Description = model.Description,
                AltDescription = model.AltDescription,
                IsActive = true,
                AddedDate = DateTime.Now,

            };
            
            this._gMDsDBContext.Department.Add(newDepartment);
            this._gMDsDBContext.SaveChanges();
            return ResponseMessage.PerformSuccess();
        }
    }
}
