using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHGridMasterDetails.Data
{
    public partial class CompanyStock
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string CumulativeQtyInStock { get; set; }

        public virtual Product Product { get; set; }
    }
}
