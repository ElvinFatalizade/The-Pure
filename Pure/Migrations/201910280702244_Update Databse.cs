namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CodintBitUrls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrlLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.CodinBits", "UrlLink");
            DropColumn("dbo.CodinBits", "Icon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CodinBits", "Icon", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.CodinBits", "UrlLink", c => c.String(nullable: false, maxLength: 100));
            DropTable("dbo.CodintBitUrls");
        }
    }
}
