using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHGridMasterDetails.Data
{
    public partial class Product
    {
        public Product()
        {
            CompanyStock = new HashSet<CompanyStock>();
        }

        public int ProductId { get; set; }
        public string ProductDescription { get; set; }

        public virtual ICollection<CompanyStock> CompanyStock { get; set; }
    }
}
