namespace MICE.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Author = c.String(),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.NewsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
