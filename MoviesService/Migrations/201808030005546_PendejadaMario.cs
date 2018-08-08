namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PendejadaMario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "PersonId", "dbo.People");
            DropIndex("dbo.Addresses", new[] { "PersonId" });
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
                        DescriptionWorkerType = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Addresses", "PersonId", c => c.String(nullable: false, maxLength: 15));
            CreateIndex("dbo.Addresses", "PersonId");
            AddForeignKey("dbo.Addresses", "PersonId", "dbo.People", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "PersonId", "dbo.People");
            DropForeignKey("dbo.JobInformations", "WorkerTypeId", "dbo.WorkerTypes");
            DropForeignKey("dbo.JobInformations", "PersonId", "dbo.People");
            DropIndex("dbo.JobInformations", new[] { "PersonId" });
            DropIndex("dbo.JobInformations", new[] { "WorkerTypeId" });
            DropIndex("dbo.Addresses", new[] { "PersonId" });
            AlterColumn("dbo.Addresses", "PersonId", c => c.String(maxLength: 15));
            DropTable("dbo.WorkerTypes");
            DropTable("dbo.JobInformations");
            CreateIndex("dbo.Addresses", "PersonId");
            AddForeignKey("dbo.Addresses", "PersonId", "dbo.People", "Id");
        }
    }
}
