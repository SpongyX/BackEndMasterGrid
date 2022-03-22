using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHGridMasterDetails.Data
{
    public partial class Import
    {
        public int ImportId { get; set; }
        public int TankerId { get; set; }
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public DateTime? AddedDate { get; set; }
        public string QtyImported { get; set; }
        public decimal? PriceImport { get; set; }
        public string QtyDelivered { get; set; }
        public int StatusId { get; set; }
    }
}
