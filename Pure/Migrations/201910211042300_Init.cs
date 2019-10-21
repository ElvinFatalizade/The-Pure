namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 100),
                        Title = c.String(nullable: false, maxLength: 100),
                        LinkName = c.String(nullable: false, maxLength: 100),
                        Price = c.Single(nullable: false),
                        Text = c.String(storeType: "ntext"),
                        LocationName = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 50),
                        Work = c.String(nullable: false, maxLength: 50),
                        Icon = c.String(maxLength: 100),
                        Text = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CodinBits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logo = c.String(nullable: false, maxLength: 50),
                        Text = c.String(storeType: "ntext"),
                        Title = c.String(nullable: false, maxLength: 50),
                        UrlLink = c.String(nullable: false, maxLength: 100),
                        Icon = c.String(nullable: false, maxLength: 100),
                        EndText = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Populars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 100),
                        Title = c.String(nullable: false, maxLength: 100),
                        Icon = c.String(nullable: false, maxLength: 100),
                        Text = c.String(storeType: "ntext"),
                        LinkName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Promoteds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 300),
                        Slug = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Photo = c.String(maxLength: 100),
                        Text = c.String(storeType: "ntext"),
                        Location = c.String(nullable: false, maxLength: 100),
                        NameUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 100),
                        Title = c.String(nullable: false, maxLength: 100),
                        Text = c.String(storeType: "ntext"),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logo = c.String(maxLength: 100),
                        Email = c.String(maxLength: 50),
                        HeaderPhone = c.String(maxLength: 50),
                        ContactPhone = c.String(maxLength: 50),
                        Adress = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SocialLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 100),
                        OrderBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialLinks");
            DropTable("dbo.Settings");
            DropTable("dbo.Recents");
            DropTable("dbo.Promoteds");
            DropTable("dbo.Populars");
            DropTable("dbo.CodinBits");
            DropTable("dbo.Clients");
            DropTable("dbo.Ads");
        }
    }
}
