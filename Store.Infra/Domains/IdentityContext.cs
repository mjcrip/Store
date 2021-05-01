using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;
using Store.Infra.Identity;
using System.Data.Entity;

namespace Store.Infra.Domains
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class IdentityContext : IdentityDbContext<AuthenticatedUser,
        AuthenticatedRole,
        int,
        AuthenticatedUserLogin,
        AuthenticatedUserRole,
        AuthenticatedUserClaim>
    {
        public IdentityContext() : base("identity")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("identity");

            modelBuilder.Entity<AuthenticatedUserRole>()
            .HasKey(r => new { r.Id });
            modelBuilder.Entity<AuthenticatedUserLogin>()
            .HasKey(r => new { r.Id });
            base.OnModelCreating(modelBuilder);
        }
        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
