using Microsoft.AspNet.Identity.EntityFramework;

namespace Store.Infra.Identity
{
    public class AuthenticatedRole : IdentityRole<int,AuthenticatedUserRole>
    {
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
