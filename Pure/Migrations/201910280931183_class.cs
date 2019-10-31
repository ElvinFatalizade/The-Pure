namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FooterEnds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FooterEndId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FooterEnds", t => t.FooterEndId, cascadeDelete: true)
                .Index(t => t.FooterEndId);
            
            DropTable("dbo.CodintBitUrls");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CodintBitUrls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrlLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Footers", "FooterEndId", "dbo.FooterEnds");
            DropIndex("dbo.Footers", new[] { "FooterEndId" });
            DropTable("dbo.Footers");
            DropTable("dbo.FooterEnds");
        }
    }
}
