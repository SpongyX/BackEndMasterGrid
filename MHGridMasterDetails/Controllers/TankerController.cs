using MHGridMasterDetails.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Controllers
{
    [Route("api/[controller]")]

    public class TankerController: ControllerBase
    {
        private ITankerService _itankerService;

        public TankerController(ITankerService itankerService)
        {
            _itankerService = itankerService;
        }

        [HttpGet]
        [Route("GetTanker")]
        public IActionResult GetTanker()
        {
            var response = _itankerService.GetTanker();
            return Ok(response);
        }
    }

}
