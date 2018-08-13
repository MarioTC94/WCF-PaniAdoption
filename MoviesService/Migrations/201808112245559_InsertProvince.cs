namespace Adoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertProvince : DbMigration
    {
		public override void Up()
		{
			Sql("INSERT INTO Provinces(ID, Name) VALUES (843, 'Alajuela');");
			Sql("INSERT INTO Provinces(ID, Name) VALUES (844, 'Cartago');");
			Sql("INSERT INTO Provinces(ID, Name) VALUES (845, 'Guanacaste');");
			Sql("INSERT INTO Provinces(ID, Name) VALUES (846, 'Heredia');");
			Sql("INSERT INTO Provinces(ID, Name) VALUES (847, 'Limon');");
			Sql("INSERT INTO Provinces(ID, Name) VALUES (848, 'Puntarenas');");
			Sql("INSERT INTO Provinces(ID, Name) VALUES (849, 'San Jose');");
		}

		public override void Down()
		{
			Sql("DELETE FROM Provinces");
		}
	}
}
