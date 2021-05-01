using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Store.Infra.Domains;
using Store.Infra.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Store
{
    public class ApplicationRoleManager : RoleManager<AuthenticatedRole, int>
    {
        public ApplicationRoleManager(IRoleStore<AuthenticatedRole, int> store) : base(store)
        {

        }

        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            return new ApplicationRoleManager(new RoleStore<AuthenticatedRole, int, AuthenticatedUserRole>(context.Get<IdentityContext>()));
        }
    }
}