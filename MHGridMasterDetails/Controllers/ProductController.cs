using MHGridMasterDetails.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Controllers
{

    [Route("api/[controller]")]
    public class ProductController :  ControllerBase
    {
        private IProductService _iproductService;

        public ProductController(IProductService iproductService)
        {
            _iproductService = iproductService;
        }

        [HttpGet]
        [Route("GetProduct")]
        public IActionResult GetProduct()
        {
            var response = _iproductService.GetProduct();
            return Ok(response);
        }
    }
}
