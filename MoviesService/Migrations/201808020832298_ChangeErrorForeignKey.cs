namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeErrorForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "PersonType_Id", "dbo.PersonTypes");
            DropForeignKey("dbo.Counties", "Province_Id", "dbo.Provinces");
            DropIndex("dbo.People", new[] { "PersonType_Id" });
            DropIndex("dbo.Counties", new[] { "Province_Id" });
            RenameColumn(table: "dbo.People", name: "PersonType_Id", newName: "PersonTypeId");
            RenameColumn(table: "dbo.Counties", name: "Province_Id", newName: "ProvinceId");
            AlterColumn("dbo.People", "PersonTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Counties", "ProvinceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Counties", "ProvinceId");
            CreateIndex("dbo.People", "PersonTypeId");
            AddForeignKey("dbo.People", "PersonTypeId", "dbo.PersonTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Counties", "ProvinceId", "dbo.Provinces", "Id", cascadeDelete: true);
            DropColumn("dbo.People", "IdPersonType");
            DropColumn("dbo.Counties", "IdProvince");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Counties", "IdProvince", c => c.Int(nullable: false));
            AddColumn("dbo.People", "IdPersonType", c => c.Int(nullable: false));
            DropForeignKey("dbo.Counties", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.People", "PersonTypeId", "dbo.PersonTypes");
            DropIndex("dbo.People", new[] { "PersonTypeId" });
            DropIndex("dbo.Counties", new[] { "ProvinceId" });
            AlterColumn("dbo.Counties", "ProvinceId", c => c.Int());
            AlterColumn("dbo.People", "PersonTypeId", c => c.Int());
            RenameColumn(table: "dbo.Counties", name: "ProvinceId", newName: "Province_Id");
            RenameColumn(table: "dbo.People", name: "PersonTypeId", newName: "PersonType_Id");
            CreateIndex("dbo.Counties", "Province_Id");
            CreateIndex("dbo.People", "PersonType_Id");
            AddForeignKey("dbo.Counties", "Province_Id", "dbo.Provinces", "Id");
            AddForeignKey("dbo.People", "PersonType_Id", "dbo.PersonTypes", "Id");
        }
    }
}
