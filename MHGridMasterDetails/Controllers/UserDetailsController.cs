using MHGridMasterDetails.Model.Dto;
using MHGridMasterDetails.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    //[Authorize]
    public class UserDetailsController : ControllerBase
    {
        private IUserDetails _iuserdetailsService;

        public UserDetailsController(IUserDetails iuserdetailsService)
        {
            _iuserdetailsService = iuserdetailsService;
        }
        //create
        [HttpPost]
        [Route("CreateDepartment")]

        public IActionResult CreateDepartment( [FromBody] DepartmentModel model)
        {
            var response = this._iuserdetailsService.CreateDepartment(model);
            return Ok(response);
        }
    }
}
