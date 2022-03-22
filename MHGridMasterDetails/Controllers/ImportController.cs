using MHGridMasterDetails.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Controllers
{
    [Route("api/[controller]")]

    public class ImportController : ControllerBase
    {
        private IImportService _iimportService;

        public ImportController(IImportService iimportService)
        {
            _iimportService = iimportService;
        }
        [HttpGet]
        [Route("GetImport")]
        public IActionResult GetImport()
        {
            var response = _iimportService.GetImport();
            return Ok(response);
        }
    }
}
