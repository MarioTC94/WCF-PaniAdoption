namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdentificationNumber = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        SecondLastName = c.String(nullable: false, maxLength: 30),
                        BirthDay = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 30),
                        Phone = c.String(nullable: false, maxLength: 15),
                        IdPersonType = c.Int(nullable: false),
                        PersonType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonTypes", t => t.PersonType_Id)
                .Index(t => t.PersonType_Id);
            
            CreateTable(
                "dbo.PersonTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "PersonType_Id", "dbo.PersonTypes");
            DropIndex("dbo.People", new[] { "PersonType_Id" });
            DropTable("dbo.PersonTypes");
            DropTable("dbo.People");
        }
    }
}
