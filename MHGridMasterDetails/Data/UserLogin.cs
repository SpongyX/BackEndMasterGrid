using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHGridMasterDetails.Data
{
    public partial class UserLogin
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? StatusId { get; set; }
        public int? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
