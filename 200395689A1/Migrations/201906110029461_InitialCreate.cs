namespace _200395689A1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Minimum_Requirements = c.String(),
                    })
                .PrimaryKey(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
