﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHGridMasterDetails.Data
{
    public partial class Status
    {
        public int StatusId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
