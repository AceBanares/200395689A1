namespace _200395689A1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Developers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        DeveloperID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.DeveloperID);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Minimum_Requirements = c.String(),
                        Publisher = c.String(),
                        Developer = c.String(),
                        Genre = c.String(),
                        Review = c.String(),
                    })
                .PrimaryKey(t => t.GameID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.PublisherID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Subject = c.String(),
                        Reviews = c.String(),
                        Stars = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
            DropTable("dbo.Publishers");
            DropTable("dbo.Genres");
            DropTable("dbo.Games");
            DropTable("dbo.Developers");
        }
    }
}
