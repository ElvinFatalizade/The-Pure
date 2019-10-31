namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CodinBits", "CodinBitUrlId", c => c.Int(nullable: false));
            DropColumn("dbo.CodinBits", "CodintBitId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CodinBits", "CodintBitId", c => c.Int(nullable: false));
            DropColumn("dbo.CodinBits", "CodinBitUrlId");
        }
    }
}
