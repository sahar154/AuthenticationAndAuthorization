using System;
using Microsoft.AspNetCore.Identity;

namespace ConfArch.IdentityProvider.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CareerStartedDate { get; set; }
        public string FullName { get; set; }
        public string TZ { get; set; }
    }
}
