using MHGridMasterDetails.Model.Company;
using MHGridMasterDetails.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Controllers
{
    [Route("api/[controller]")]

    public class CompanyController : ControllerBase
    {
        private ICompanyService _icompanyService;

        public CompanyController(ICompanyService icompanyService)
        {
            _icompanyService = icompanyService;
        }
        [HttpGet]
        [Route("GetCompany")]
        public IActionResult GetCompany()
        {
            var response = _icompanyService.GetCompany();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetCompanyStock/{id}")]
        public IActionResult GetCompanyStock(int id)
        {
            var response = _icompanyService.GetCompanyStock(id);
            return Ok(response);
        }

        //[HttpPost]
        //[Route("CreateCompany")]
        //public IActionResult CreateCompany([FromBody] NewCompanyModel model)
        //{
        //    var response = this._icompanyService.CreateCompany(model);
        //    return Ok(response);
        //}
    }
}
