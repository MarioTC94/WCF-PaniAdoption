namespace Adoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertRoomHouse : DbMigration
    {
		public override void Up()
		{
			Sql("INSERT INTO RoomHouses(Description) VALUES ('Propia');");
			Sql("INSERT INTO RoomHouses(Description) VALUES ('Alquilada');");
			Sql("INSERT INTO RoomHouses(Description) VALUES ('Prestada');");
		}

		public override void Down()
		{
			Sql("DELETE FROM RoomHouses WHERE Description IN ('Propia', 'Alquilada', 'Prestada')");
		}
	}
}
