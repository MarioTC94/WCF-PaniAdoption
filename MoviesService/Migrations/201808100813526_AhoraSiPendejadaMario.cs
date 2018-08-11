namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AhoraSiPendejadaMario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "PersonId", "dbo.People");
            DropIndex("dbo.Addresses", new[] { "PersonId" });
            DropPrimaryKey("dbo.People");
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
            
            CreateTable(
                "dbo.JobInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 20),
                        ActualPosition = c.String(nullable: false, maxLength: 20),
                        AnualSalary = c.Decimal(nullable: false, precision: 10, scale: 2),
                        Phone = c.String(nullable: false, maxLength: 20),
                        AddressCompany = c.String(nullable: false, maxLength: 300),
                        WorkerTypeId = c.Int(nullable: false),
                        PersonId = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId)
                .ForeignKey("dbo.WorkerTypes", t => t.WorkerTypeId, cascadeDelete: true)
                .Index(t => t.WorkerTypeId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.WorkerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Addresses", "PersonId", c => c.String(nullable: false, maxLength: 15));
			DropColumn("dbo.People", "Id");
			AddColumn("dbo.People", "Id", c => c.String(nullable: false, maxLength: 15));
            AddPrimaryKey("dbo.People", "Id");
            CreateIndex("dbo.Addresses", "PersonId");
            AddForeignKey("dbo.Addresses", "PersonId", "dbo.People", "Id", cascadeDelete: true);
            DropColumn("dbo.People", "IdentificationNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "IdentificationNumber", c => c.String(nullable: false, maxLength: 15));
            DropForeignKey("dbo.Addresses", "PersonId", "dbo.People");
            DropForeignKey("dbo.JobInformations", "WorkerTypeId", "dbo.WorkerTypes");
            DropForeignKey("dbo.JobInformations", "PersonId", "dbo.People");
            DropForeignKey("dbo.MarriageInformations", "RoomHouseId", "dbo.RoomHouses");
            DropForeignKey("dbo.MarriageInformations", "MotherId", "dbo.People");
            DropForeignKey("dbo.MarriageInformations", "MaritalStateId", "dbo.MaritalStates");
            DropForeignKey("dbo.MarriageInformations", "FatherId", "dbo.People");
            DropForeignKey("dbo.AdoptionProcesses", "StateFileId", "dbo.StateFiles");
            DropForeignKey("dbo.AdoptionProcesses", "MarriageInformationId", "dbo.MarriageInformations");
            DropIndex("dbo.JobInformations", new[] { "PersonId" });
            DropIndex("dbo.JobInformations", new[] { "WorkerTypeId" });
            DropIndex("dbo.AdoptionProcesses", new[] { "MarriageInformationId" });
            DropIndex("dbo.AdoptionProcesses", new[] { "StateFileId" });
            DropIndex("dbo.MarriageInformations", new[] { "FatherId" });
            DropIndex("dbo.MarriageInformations", new[] { "MotherId" });
            DropIndex("dbo.MarriageInformations", new[] { "RoomHouseId" });
            DropIndex("dbo.MarriageInformations", new[] { "MaritalStateId" });
            DropIndex("dbo.Addresses", new[] { "PersonId" });
            DropPrimaryKey("dbo.People");
			DropColumn("dbo.People", "Id");
            AddColumn("dbo.People", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Addresses", "PersonId", c => c.Int(nullable: false));
            DropTable("dbo.WorkerTypes");
            DropTable("dbo.JobInformations");
            DropTable("dbo.RoomHouses");
            DropTable("dbo.MaritalStates");
            DropTable("dbo.StateFiles");
            DropTable("dbo.AdoptionProcesses");
            DropTable("dbo.MarriageInformations");
            AddPrimaryKey("dbo.People", "Id");
            CreateIndex("dbo.Addresses", "PersonId");
            AddForeignKey("dbo.Addresses", "PersonId", "dbo.People", "Id", cascadeDelete: true);
        }
    }
}
