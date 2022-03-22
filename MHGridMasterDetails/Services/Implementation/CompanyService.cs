using MHGridMasterDetails.Data;
using MHGridMasterDetails.Model.Company;
using MHGridMasterDetails.Model.ResponseMessage;
using MHGridMasterDetails.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Implementation
{
    public class CompanyService : ICompanyService
    {
        private GMDsDBContext _gMDsDBContext;
        public CompanyService(GMDsDBContext gMDsDBContext)
        {
            _gMDsDBContext = gMDsDBContext;
        }

        public ResponseMessage CreateCompany(NewCompanyModel model)
        {
            var newCompany = new Company()
            {
               //UserCode = model.UserCode,
                //Description = model.Description,
                //AddedFuelQty = model.AddedFuelQty,
                //FuelQty = model.FuelQty,
                //AddedDate = DateTime.Now,
                //IsActive = true
            };
            this._gMDsDBContext.Company.Add(newCompany);
            this._gMDsDBContext.SaveChanges();
            return ResponseMessage.PerformSuccess();
        }

        public ResponseMessage GetCompany()
        {
            try
            {
                var model = this._gMDsDBContext.Company.ToList();
        
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                //HelperContext.Log("GetPackages", "ProjectInfoService", "GetPackages", ErrorCodes.Exception.ToString(), ex.Message, -1, ex, this._httpContext);
                return ResponseMessage.PerformError(ex.Message);
            }
        }

        public ResponseMessage GetCompanyStock(int company_id)
        {
            try
            
            {
                //var model = this._gMDsDBContext.CompanyStock.ToList();
                var model = (from cs in _gMDsDBContext.CompanyStock
                             join p in _gMDsDBContext.Product
                             on cs.ProductId equals p.ProductId
                             where cs.CompanyId == company_id

                             select new CompanyStockDetailModel
                             {
                                 ProductName = p.ProductDescription,
                                 StockQuantity = cs.CumulativeQtyInStock,
                             }).ToList();
                return ResponseMessage.PerformSuccess(model);
            }
            catch (Exception ex)
            {
                return ResponseMessage.PerformError(ex.Message);

            }
        }
        }

        //public ResponseMessage GetCompanyData()
        //{
        //    try
        //    {
        //        var companyObject = this._gMDsDBContext.Company.Where(x => x.IsActive == true).ToList();

        //        //if (companyObject.IsActive == null)
        //        //{
        //        //    return ResponseMessage.PerformError("Company Not Exist");
        //        //}
        //        return ResponseMessage.PerformSuccess(companyObject);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ResponseMessage.PerformError(ex.Message);
        //    }
        //}
    }

