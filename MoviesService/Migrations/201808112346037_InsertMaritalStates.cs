namespace Adoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMaritalStates : DbMigration
    {
		public override void Up()
		{
			Sql("INSERT INTO MaritalStates(Description) VALUES('Casados');");
			Sql("INSERT INTO MaritalStates(Description) VALUES('Unión Libre');");
		}

		public override void Down()
		{
			Sql("DELETE FROM MaritalStates WHERE Description IN ('Casados', 'Unión Libre');");
		}
	}
}
