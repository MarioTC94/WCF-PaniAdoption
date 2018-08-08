namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTableAddress : DbMigration
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
					PersonId = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Counties", t => t.CountyId)
				.ForeignKey("dbo.Districts", t => t.DistrictId)
				.ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
				.ForeignKey("dbo.Provinces", t => t.ProvinceId)
				.Index(t => t.ProvinceId)
				.Index(t => t.CountyId)
				.Index(t => t.DistrictId)
				.Index(t => t.PersonId);
            
            AlterColumn("dbo.Districts", "Name", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.Addresses", "PersonId", "dbo.People");
            DropForeignKey("dbo.Addresses", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Addresses", "CountyId", "dbo.Counties");
            DropIndex("dbo.Addresses", new[] { "PersonId" });
            DropIndex("dbo.Addresses", new[] { "DistrictId" });
            DropIndex("dbo.Addresses", new[] { "CountyId" });
            DropIndex("dbo.Addresses", new[] { "ProvinceId" });
            AlterColumn("dbo.Districts", "Name", c => c.String());
            DropTable("dbo.Addresses");
        }
    }
}
