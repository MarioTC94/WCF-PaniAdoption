namespace Adoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertPersonType : DbMigration
    {
		public override void Up()
		{
			Sql("INSERT INTO PersonTypes(Description) VALUES ('Padre');");
			Sql("INSERT INTO PersonTypes(Description) VALUES ('Madre');");
		}

		public override void Down()
		{
			Sql("DELETE FROM PersonTypes WHERE Description IN ('Padre', 'Madre');");
		}
	}
}
