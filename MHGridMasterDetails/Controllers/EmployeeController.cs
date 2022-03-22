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
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _iemployeeService;

        public EmployeeController(IEmployeeService iemployeeService)
        {
            _iemployeeService = iemployeeService;
        }
        //create
        [HttpPost]
        [Route("CreateUser")]

        public IActionResult CreateUser([FromBody] UserModel model)
        {
            var response = this._iemployeeService.CreateUser(model);
            return Ok(response);
        }
        [HttpPost]
        [Route("UpdateUser")]
        public IActionResult UpdateProduct([FromBody]  UserModel model)
        {
            var response = this._iemployeeService.UpdateUser(model);
            return Ok(response);
        }
        [HttpGet]
        [Route("GetEmployee")]
        public IActionResult GetEmployee()
        {
            var response = _iemployeeService.GetEmployee();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetEmployeeById/{id}")]

        public IActionResult GetEmployeeById(int id)
        {
            var response = this._iemployeeService.GetEmployeeById(id);
            return Ok(response);
        }

        [HttpPost]
        [Route("DeleteEmployee/{id}")]

        public IActionResult DeleteEmployee(int id)
        {
            var response = this._iemployeeService.DeleteEmployee(id);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetGender")]
        public IActionResult GetGender()
        {
            var response = _iemployeeService.GetGender();
            return Ok(response);
        }

        [HttpGet]
        [Route("GetDepartment")]
        public IActionResult GetDepartment()
        {
            var response = _iemployeeService.GetDepartment();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetLevel")]
        public IActionResult GetLevel()
        {
            var response = this._iemployeeService.GetLevel();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetCountry")]
        public IActionResult GetCountry()
        {
            var response = this._iemployeeService.GetCountry();
            return Ok(response);
        }

    }
}

