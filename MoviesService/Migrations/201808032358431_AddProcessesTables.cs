namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProcessesTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdoptionProcesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProcessDescripction = c.String(nullable: false, maxLength: 100),
                        AllDocuments = c.Boolean(nullable: false),
                        ParentsInterview = c.Boolean(nullable: false),
                        FamilyVisit = c.Boolean(nullable: false),
                        IDKid = c.String(nullable: false, maxLength: 15),
                        StateFileId = c.Int(nullable: false),
                        MarriageInformationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarriageInformations", t => t.MarriageInformationId, cascadeDelete: true)
                .ForeignKey("dbo.StateFiles", t => t.StateFileId, cascadeDelete: true)
                .Index(t => t.StateFileId)
                .Index(t => t.MarriageInformationId);
            
            CreateTable(
                "dbo.StateFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdoptionProcesses", "StateFileId", "dbo.StateFiles");
            DropForeignKey("dbo.AdoptionProcesses", "MarriageInformationId", "dbo.MarriageInformations");
            DropIndex("dbo.AdoptionProcesses", new[] { "MarriageInformationId" });
            DropIndex("dbo.AdoptionProcesses", new[] { "StateFileId" });
            DropTable("dbo.StateFiles");
            DropTable("dbo.AdoptionProcesses");
        }
    }
}
