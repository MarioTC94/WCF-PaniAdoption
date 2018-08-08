namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMariageTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarriageInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarriageDate = c.DateTime(nullable: false),
                        MaritalStateId = c.Int(nullable: false),
                        RoomHouseId = c.Int(nullable: false),
                        MotherId = c.String(nullable: false, maxLength: 15),
                        FatherId = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.FatherId)
                .ForeignKey("dbo.MaritalStates", t => t.MaritalStateId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.MotherId)
                .ForeignKey("dbo.RoomHouses", t => t.RoomHouseId, cascadeDelete: true)
                .Index(t => t.MaritalStateId)
                .Index(t => t.RoomHouseId)
                .Index(t => t.MotherId)
                .Index(t => t.FatherId);
            
            CreateTable(
                "dbo.MaritalStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomHouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MarriageInformations", "RoomHouseId", "dbo.RoomHouses");
            DropForeignKey("dbo.MarriageInformations", "MotherId", "dbo.People");
            DropForeignKey("dbo.MarriageInformations", "MaritalStateId", "dbo.MaritalStates");
            DropForeignKey("dbo.MarriageInformations", "FatherId", "dbo.People");
            DropIndex("dbo.MarriageInformations", new[] { "FatherId" });
            DropIndex("dbo.MarriageInformations", new[] { "MotherId" });
            DropIndex("dbo.MarriageInformations", new[] { "RoomHouseId" });
            DropIndex("dbo.MarriageInformations", new[] { "MaritalStateId" });
            DropTable("dbo.RoomHouses");
            DropTable("dbo.MaritalStates");
            DropTable("dbo.MarriageInformations");
        }
    }
}
