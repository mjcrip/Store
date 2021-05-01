using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Store.Infra.Identity
{
    public class AuthenticatedUserRole : IdentityUserRole<int>
    {
        //[Key]
        public int Id { get; set; }
    }
}
