namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CodinBits", "CodintBitId", c => c.Int(nullable: false));
            AddColumn("dbo.CodinBits", "CodintBitUrl_Id", c => c.Int());
            CreateIndex("dbo.CodinBits", "CodintBitUrl_Id");
            AddForeignKey("dbo.CodinBits", "CodintBitUrl_Id", "dbo.CodintBitUrls", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CodinBits", "CodintBitUrl_Id", "dbo.CodintBitUrls");
            DropIndex("dbo.CodinBits", new[] { "CodintBitUrl_Id" });
            DropColumn("dbo.CodinBits", "CodintBitUrl_Id");
            DropColumn("dbo.CodinBits", "CodintBitId");
        }
    }
}
