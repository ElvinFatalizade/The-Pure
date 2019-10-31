namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class choose : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Footers", "FooterEndId", "dbo.FooterEnds");
            DropIndex("dbo.Footers", new[] { "FooterEndId" });
            CreateTable(
                "dbo.ChooseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.FooterEnds");
            DropTable("dbo.Footers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FooterEndId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FooterEnds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ChooseCategories");
            CreateIndex("dbo.Footers", "FooterEndId");
            AddForeignKey("dbo.Footers", "FooterEndId", "dbo.FooterEnds", "Id", cascadeDelete: true);
        }
    }
}
