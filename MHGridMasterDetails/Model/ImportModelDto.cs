using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Model
{
    public class ImportModelDto
    {
        public string tankerName { get; set; }
        public string companyName { get; set; }
        public string productDescription { get; set; }
        public string qtyImported { get; set; }
        public decimal? priceImport { get; set; }
        public string qtyDelivered { get; set; }
    }
}
