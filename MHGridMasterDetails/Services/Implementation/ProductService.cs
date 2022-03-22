using MHGridMasterDetails.Data;
using MHGridMasterDetails.Model.ResponseMessage;
using MHGridMasterDetails.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Implementation
{
    public class ProductService : IProductService
    {
        private GMDsDBContext _gMDsDBContext;
        //private HttpContext _httpContext;
        //private IConfiguration _config;

        public ProductService(
      GMDsDBContext gMDsDBContext
            //IHttpContextAccessor httpContextAccessor,
            //IConfiguration config
            )
        {
            _gMDsDBContext = gMDsDBContext;
            //_httpContext = httpContextAccessor.HttpContext;
            //_config = config;
        }
        public ResponseMessage GetProduct()
        {
            try
            {
                var model = this._gMDsDBContext.Product.ToList();
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                // HelperContext.Log("GetMilestone", "ProjectInfoService", "GetMilestone", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError(ex.Message);
            }
        }
    }
}
