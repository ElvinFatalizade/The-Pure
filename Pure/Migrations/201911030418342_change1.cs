namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ads", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ads", "Date", c => c.DateTime(nullable: false));
        }
    }
}
