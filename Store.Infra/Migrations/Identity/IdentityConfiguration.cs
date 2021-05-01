namespace Store.Infra.Migrations.Identity
{
    using Store.Infra.Domains;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class IdentityConfiguration : DbMigrationsConfiguration<Store.Infra.Domains.IdentityContext>
    {
        public IdentityConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
            this.SetHistoryContextFactory("MySql.Data.MySqlClient", (connection, defaultSchema) => new MigrationHistoryContext(connection, defaultSchema));
        }

        protected override void Seed(Store.Infra.Domains.IdentityContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
