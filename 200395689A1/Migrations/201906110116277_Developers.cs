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
                        Stars = c.String(),
                    })
                .PrimaryKey(t => t.ReviewID);
            
            AddColumn("dbo.Games", "Publisher", c => c.String());
            AddColumn("dbo.Games", "Review", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Review");
            DropColumn("dbo.Games", "Publisher");
            DropTable("dbo.Reviews");
            DropTable("dbo.Publishers");
            DropTable("dbo.Genres");
            DropTable("dbo.Developers");
        }
    }
}
