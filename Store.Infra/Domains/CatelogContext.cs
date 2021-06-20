using MySql.Data.EntityFramework;
using Store.Core.Entities.Associations;
using Store.Core.Entities.Catelog;
using Store.Core.Entities.Ecosystem;
using Store.Core.Entities.Sports;
using Store.Core.Interfaces;
using Store.Infra.Shared;
using System.Data.Entity;

namespace Store.Infra.Domains
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class CatelogContext : EntityContext
    {
		public CatelogContext() : base(ContextNames.Catelog)
		{ 

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.HasDefaultSchema("catelog");
		}

		#region Associations
		public DbSet<SportProduct> SportProductMappings { get; set; }

		#endregion

		#region Catelog
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<Property> Properties { get; set; }
		public DbSet<PropertyType> PropertyTypes { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
		#endregion

		#region Ecosystem
		public DbSet<Person> People { get; set; }
        #endregion

        #region Sports
        public DbSet<Club> Clubs { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<ClubType> ClubTypes { get; set; }
		public DbSet<League> Leagues { get; set; }
		public DbSet<PlayerProfile> playerProfiles { get; set; }
		public DbSet<Player> Players { get; set; }
		public DbSet<Sport> Sports { get; set; }
		public DbSet<SportType> SportTypes  { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<TeamLeague> TeamLeagueMappings { get; set; }
		public DbSet<TeamPlayer> TeamPlayerMappings  { get; set; }
        #endregion
    }
}
