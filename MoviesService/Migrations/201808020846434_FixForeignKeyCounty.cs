namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixForeignKeyCounty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Districts", "County_Id", "dbo.Counties");
            DropIndex("dbo.Districts", new[] { "County_Id" });
            RenameColumn(table: "dbo.Districts", name: "County_Id", newName: "CountyId");
            AlterColumn("dbo.Districts", "CountyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Districts", "CountyId");
            AddForeignKey("dbo.Districts", "CountyId", "dbo.Counties", "Id", cascadeDelete: true);
            DropColumn("dbo.Districts", "IdCounty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Districts", "IdCounty", c => c.Int(nullable: false));
            DropForeignKey("dbo.Districts", "CountyId", "dbo.Counties");
            DropIndex("dbo.Districts", new[] { "CountyId" });
            AlterColumn("dbo.Districts", "CountyId", c => c.Int());
            RenameColumn(table: "dbo.Districts", name: "CountyId", newName: "County_Id");
            CreateIndex("dbo.Districts", "County_Id");
            AddForeignKey("dbo.Districts", "County_Id", "dbo.Counties", "Id");
        }
    }
}
