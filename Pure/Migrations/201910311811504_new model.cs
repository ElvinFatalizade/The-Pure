namespace Pure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favirites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Favirites");
        }
    }
}
