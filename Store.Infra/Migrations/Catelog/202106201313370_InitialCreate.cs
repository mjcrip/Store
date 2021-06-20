namespace Store.Infra.Migrations.Catelog
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PropertyTypeId = c.Int(nullable: false),
                        Value = c.String(unicode: false),
                        CategoryId = c.Int(),
                        ProductId = c.Int(),
                        ProductTypeId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PropertyTypes", t => t.PropertyTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeId)
                .Index(t => t.PropertyTypeId)
                .Index(t => t.CategoryId)
                .Index(t => t.ProductId)
                .Index(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.PropertyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prefix = c.String(unicode: false),
                        Name = c.String(unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        WebsiteUrl = c.String(unicode: false),
                        TypeId = c.Int(nullable: false),
                        OrganizationName = c.String(unicode: false),
                        Department = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClubTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.ClubTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(unicode: false),
                        ImageThumbUrl = c.String(unicode: false),
                        PlayerId = c.Int(),
                        ClubId = c.Int(),
                        LeagueId = c.Int(),
                        TeamId = c.Int(),
                        SportId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId)
                .ForeignKey("dbo.Leagues", t => t.LeagueId)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.PlayerId)
                .Index(t => t.ClubId)
                .Index(t => t.LeagueId)
                .Index(t => t.TeamId)
                .Index(t => t.SportId);
            
            CreateTable(
                "dbo.Leagues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                        SportId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sports", t => t.SportId, cascadeDelete: true)
                .Index(t => t.SportId);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        TypeId = c.Int(nullable: false),
                        Excercise = c.Int(nullable: false),
                        Description = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SportTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.SportTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.Sports", t => t.SportId, cascadeDelete: true)
                .Index(t => t.SportId)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        MiddleName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportId = c.Int(nullable: false),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        ClubId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId)
                .ForeignKey("dbo.Sports", t => t.SportId, cascadeDelete: true)
                .Index(t => t.SportId)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.PlayerProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gender = c.Int(nullable: false),
                        Description = c.String(unicode: false),
                        PlayerId = c.Int(nullable: false),
                        Breif = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublicUrl = c.String(unicode: false),
                        PublicThumblUrl = c.String(unicode: false),
                        FileName = c.String(maxLength: 100, storeType: "nvarchar"),
                        Order = c.Int(nullable: false),
                        IsDefault = c.Boolean(nullable: false),
                        Type = c.Int(),
                        EntityId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sku = c.String(maxLength: 100, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        ProductTypeId = c.Int(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AffiliateUrl = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeId)
                .Index(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prefix = c.String(maxLength: 50, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.SportProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(),
                        ClubId = c.Int(),
                        LeagueId = c.Int(),
                        TeamId = c.Int(),
                        SportId = c.Int(),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId)
                .ForeignKey("dbo.Leagues", t => t.LeagueId)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.PlayerId)
                .Index(t => t.ClubId)
                .Index(t => t.LeagueId)
                .Index(t => t.TeamId)
                .Index(t => t.SportId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.TeamLeagues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        LeagueId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Leagues", t => t.LeagueId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.LeagueId);
            
            CreateTable(
                "dbo.TeamPlayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        AssocitedFrom = c.DateTime(nullable: false, precision: 0),
                        AssociatedTo = c.DateTime(precision: 0),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedBy = c.String(unicode: false),
                        CreatedBy = c.String(unicode: false),
                        DeletedBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamPlayers", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamPlayers", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.TeamLeagues", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamLeagues", "LeagueId", "dbo.Leagues");
            DropForeignKey("dbo.SportProducts", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.SportProducts", "SportId", "dbo.Sports");
            DropForeignKey("dbo.SportProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SportProducts", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.SportProducts", "LeagueId", "dbo.Leagues");
            DropForeignKey("dbo.SportProducts", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.Properties", "ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.ProductTypes", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Properties", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PlayerProfiles", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.Images", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Teams", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Images", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Images", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.Players", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Players", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Images", "LeagueId", "dbo.Leagues");
            DropForeignKey("dbo.Leagues", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Sports", "TypeId", "dbo.SportTypes");
            DropForeignKey("dbo.Images", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Clubs", "TypeId", "dbo.ClubTypes");
            DropForeignKey("dbo.Properties", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Properties", "PropertyTypeId", "dbo.PropertyTypes");
            DropIndex("dbo.TeamPlayers", new[] { "PlayerId" });
            DropIndex("dbo.TeamPlayers", new[] { "TeamId" });
            DropIndex("dbo.TeamLeagues", new[] { "LeagueId" });
            DropIndex("dbo.TeamLeagues", new[] { "TeamId" });
            DropIndex("dbo.SportProducts", new[] { "ProductId" });
            DropIndex("dbo.SportProducts", new[] { "SportId" });
            DropIndex("dbo.SportProducts", new[] { "TeamId" });
            DropIndex("dbo.SportProducts", new[] { "LeagueId" });
            DropIndex("dbo.SportProducts", new[] { "ClubId" });
            DropIndex("dbo.SportProducts", new[] { "PlayerId" });
            DropIndex("dbo.ProductTypes", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "ProductTypeId" });
            DropIndex("dbo.PlayerProfiles", new[] { "PlayerId" });
            DropIndex("dbo.Teams", new[] { "ClubId" });
            DropIndex("dbo.Teams", new[] { "SportId" });
            DropIndex("dbo.Players", new[] { "Person_Id" });
            DropIndex("dbo.Players", new[] { "SportId" });
            DropIndex("dbo.Sports", new[] { "TypeId" });
            DropIndex("dbo.Leagues", new[] { "SportId" });
            DropIndex("dbo.Images", new[] { "SportId" });
            DropIndex("dbo.Images", new[] { "TeamId" });
            DropIndex("dbo.Images", new[] { "LeagueId" });
            DropIndex("dbo.Images", new[] { "ClubId" });
            DropIndex("dbo.Images", new[] { "PlayerId" });
            DropIndex("dbo.Clubs", new[] { "TypeId" });
            DropIndex("dbo.Properties", new[] { "ProductTypeId" });
            DropIndex("dbo.Properties", new[] { "ProductId" });
            DropIndex("dbo.Properties", new[] { "CategoryId" });
            DropIndex("dbo.Properties", new[] { "PropertyTypeId" });
            DropTable("dbo.TeamPlayers");
            DropTable("dbo.TeamLeagues");
            DropTable("dbo.SportProducts");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.ProductImages");
            DropTable("dbo.PlayerProfiles");
            DropTable("dbo.Teams");
            DropTable("dbo.People");
            DropTable("dbo.Players");
            DropTable("dbo.SportTypes");
            DropTable("dbo.Sports");
            DropTable("dbo.Leagues");
            DropTable("dbo.Images");
            DropTable("dbo.ClubTypes");
            DropTable("dbo.Clubs");
            DropTable("dbo.PropertyTypes");
            DropTable("dbo.Properties");
            DropTable("dbo.Categories");
        }
    }
}
