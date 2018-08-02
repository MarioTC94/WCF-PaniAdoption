namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDirectionTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        IdProvince = c.Int(nullable: false),
                        Province_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.Province_Id)
                .Index(t => t.Province_Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        IdCounty = c.Int(nullable: false),
                        County_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Counties", t => t.County_Id)
                .Index(t => t.County_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Counties", "Province_Id", "dbo.Provinces");
            DropForeignKey("dbo.Districts", "County_Id", "dbo.Counties");
            DropIndex("dbo.Districts", new[] { "County_Id" });
            DropIndex("dbo.Counties", new[] { "Province_Id" });
            DropTable("dbo.Districts");
            DropTable("dbo.Counties");
            DropTable("dbo.Provinces");
        }
    }
}
