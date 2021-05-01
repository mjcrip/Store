using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Store.Infra.Identity
{
    public class AuthenticatedUser : IdentityUser<int,AuthenticatedUserLogin,AuthenticatedUserRole,AuthenticatedUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AuthenticatedUser,int> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public int PersonId { get; set; }
        public bool RememberMe { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
