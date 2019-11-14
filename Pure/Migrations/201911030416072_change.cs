namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ads", "Photo", c => c.String());
            AlterColumn("dbo.Ads", "Title", c => c.String());
            AlterColumn("dbo.Ads", "LinkName", c => c.String());
            AlterColumn("dbo.Ads", "Text", c => c.String());
            AlterColumn("dbo.Ads", "LocationName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ads", "LocationName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Ads", "Text", c => c.String(storeType: "ntext"));
            AlterColumn("dbo.Ads", "LinkName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Ads", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Ads", "Photo", c => c.String(maxLength: 100));
        }
    }
}
