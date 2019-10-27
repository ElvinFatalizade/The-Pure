namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modelsupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Promoteds", "Slug");
            DropColumn("dbo.Promoteds", "Text");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Promoteds", "Text", c => c.String(storeType: "ntext"));
            AddColumn("dbo.Promoteds", "Slug", c => c.String(nullable: false));
        }
    }
}
