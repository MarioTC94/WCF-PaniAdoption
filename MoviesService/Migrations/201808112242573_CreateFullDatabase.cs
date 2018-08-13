namespace Adoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFullDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProvinceId = c.Int(nullable: false),
                        CountyId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        AddressDescription = c.String(nullable: false, maxLength: 300),
                        MarriageInformationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Counties", t => t.CountyId)
                .ForeignKey("dbo.Districts", t => t.DistrictId)
                .ForeignKey("dbo.MarriageInformations", t => t.MarriageInformationId, cascadeDelete: true)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId)
                .Index(t => t.ProvinceId)
                .Index(t => t.CountyId)
                .Index(t => t.DistrictId)
                .Index(t => t.MarriageInformationId);
            
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        ProvinceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId, cascadeDelete: true)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 40),
                        CountyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Counties", t => t.CountyId, cascadeDelete: true)
                .Index(t => t.CountyId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.People",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        SecondLastName = c.String(nullable: false, maxLength: 30),
                        BirthDay = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 30),
                        Phone = c.String(nullable: false, maxLength: 15),
                        PersonTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonTypes", t => t.PersonTypeId, cascadeDelete: true)
                .Index(t => t.PersonTypeId);
            
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
            
            CreateTable(
                "dbo.PersonTypes",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.MarriageInformations", "RoomHouseId", "dbo.RoomHouses");
            DropForeignKey("dbo.MarriageInformations", "MotherId", "dbo.People");
            DropForeignKey("dbo.MarriageInformations", "MaritalStateId", "dbo.MaritalStates");
            DropForeignKey("dbo.MarriageInformations", "FatherId", "dbo.People");
            DropForeignKey("dbo.People", "PersonTypeId", "dbo.PersonTypes");
            DropForeignKey("dbo.JobInformations", "WorkerTypeId", "dbo.WorkerTypes");
            DropForeignKey("dbo.JobInformations", "PersonId", "dbo.People");
            DropForeignKey("dbo.AdoptionProcesses", "StateFileId", "dbo.StateFiles");
            DropForeignKey("dbo.AdoptionProcesses", "MarriageInformationId", "dbo.MarriageInformations");
            DropForeignKey("dbo.Addresses", "MarriageInformationId", "dbo.MarriageInformations");
            DropForeignKey("dbo.Addresses", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Addresses", "CountyId", "dbo.Counties");
            DropForeignKey("dbo.Counties", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Districts", "CountyId", "dbo.Counties");
            DropIndex("dbo.JobInformations", new[] { "PersonId" });
            DropIndex("dbo.JobInformations", new[] { "WorkerTypeId" });
            DropIndex("dbo.People", new[] { "PersonTypeId" });
            DropIndex("dbo.AdoptionProcesses", new[] { "MarriageInformationId" });
            DropIndex("dbo.AdoptionProcesses", new[] { "StateFileId" });
            DropIndex("dbo.MarriageInformations", new[] { "FatherId" });
            DropIndex("dbo.MarriageInformations", new[] { "MotherId" });
            DropIndex("dbo.MarriageInformations", new[] { "RoomHouseId" });
            DropIndex("dbo.MarriageInformations", new[] { "MaritalStateId" });
            DropIndex("dbo.Districts", new[] { "CountyId" });
            DropIndex("dbo.Counties", new[] { "ProvinceId" });
            DropIndex("dbo.Addresses", new[] { "MarriageInformationId" });
            DropIndex("dbo.Addresses", new[] { "DistrictId" });
            DropIndex("dbo.Addresses", new[] { "CountyId" });
            DropIndex("dbo.Addresses", new[] { "ProvinceId" });
            DropTable("dbo.RoomHouses");
            DropTable("dbo.MaritalStates");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.WorkerTypes");
            DropTable("dbo.JobInformations");
            DropTable("dbo.People");
            DropTable("dbo.StateFiles");
            DropTable("dbo.AdoptionProcesses");
            DropTable("dbo.MarriageInformations");
            DropTable("dbo.Provinces");
            DropTable("dbo.Districts");
            DropTable("dbo.Counties");
            DropTable("dbo.Addresses");
        }
    }
}
