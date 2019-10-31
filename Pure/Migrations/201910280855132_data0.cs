namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data0 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CodinBits", "CodintBitUrl_Id", "dbo.CodintBitUrls");
            DropIndex("dbo.CodinBits", new[] { "CodintBitUrl_Id" });
            DropColumn("dbo.CodinBits", "Title");
            DropColumn("dbo.CodinBits", "CodinBitUrlId");
            DropColumn("dbo.CodinBits", "CodintBitUrl_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CodinBits", "CodintBitUrl_Id", c => c.Int());
            AddColumn("dbo.CodinBits", "CodinBitUrlId", c => c.Int(nullable: false));
            AddColumn("dbo.CodinBits", "Title", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.CodinBits", "CodintBitUrl_Id");
            AddForeignKey("dbo.CodinBits", "CodintBitUrl_Id", "dbo.CodintBitUrls", "Id");
        }
    }
}
