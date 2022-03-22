using MHGridMasterDetails.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model.Company
{
    public class CompanyStockDetailModel
    {
        public string ProductName { get; set; }
        public string StockQuantity { get; set; }
        //public List<CompanyStock> CompanyStockList { get; set; }
        //public int ProductId { get; set; }
        //public string ProductDescription { get; set; }
        //public string CumulativeQtyInStock { get; set; }
    }
}
