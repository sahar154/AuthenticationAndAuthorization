﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ConfArch.IdentityProvider.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace ConfArch.IdentityProvider.Areas.Identity
{
    public class ApplicationUserClaimsPrincipalFactory:
        UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public ApplicationUserClaimsPrincipalFactory(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> options
            ): base (userManager, roleManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> 
            GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("CareerStarted",
                user.CareerStartedDate.ToShortDateString()));
            identity.AddClaim(new Claim("FullName",
                user.FullName));
            identity.AddClaim(new Claim("TZ",
                user.TZ));

            return identity;
        }
    }
}
