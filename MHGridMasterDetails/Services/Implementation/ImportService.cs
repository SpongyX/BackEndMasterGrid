using MHGridMasterDetails.Data;
using MHGridMasterDetails.Model;
using MHGridMasterDetails.Model.ResponseMessage;
using MHGridMasterDetails.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Implementation
{
    public class ImportService : IImportService
    {
        private GMDsDBContext _gMDsDBContext;
        public ImportService(GMDsDBContext gMDsDBContext)
        {
            _gMDsDBContext = gMDsDBContext;
        }

        public ResponseMessage GetImport()
        {
            try
            {
                //var model = this._gMDsDBContext.Import.ToList();
                var model = (from i in _gMDsDBContext.Import
                             join t in _gMDsDBContext.Tanker
                             on i.TankerId equals t.TankerId
                             join c in _gMDsDBContext.Company
                             on i.CompanyId equals c.CompanyId
                             join p in _gMDsDBContext.Product
                             on i.ProductId equals p.ProductId
                             //join c in _gMDsDBContext.Countries
                             //on u.CountryId equals c.CountryId
                             //where u.IsActive == true
                             select new ImportModelDto
                             {
                                 tankerName = t.TankerName,
                                 companyName = c.CompanyName,
                                 productDescription = p.ProductDescription,
                                 qtyImported = i.QtyImported,
                                 priceImport = i.PriceImport,
                                 qtyDelivered = i.QtyDelivered
                             });

                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                //HelperContext.Log("GetPackages", "ProjectInfoService", "GetPackages", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError(ex.Message);
            }
        }
    }
}
