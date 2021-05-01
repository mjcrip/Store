namespace Store.Infra.Migrations.Catelog
{
    using Store.Infra.Domains;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class CatelogConfiguration : DbMigrationsConfiguration<Store.Infra.Domains.CatelogContext>
    {
        public CatelogConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Catelog";
            this.SetHistoryContextFactory("MySql.Data.MySqlClient", (connection, defaultSchema) => new MigrationHistoryContext(connection, defaultSchema));
        }

        protected override void Seed(Store.Infra.Domains.CatelogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
