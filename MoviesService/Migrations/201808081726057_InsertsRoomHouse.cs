namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertsRoomHouse : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO RoomHouses(Description) VALUES('Propia');");
			Sql("INSERT INTO RoomHouses(Description) VALUES('Alquiler');");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM RoomHouses WHERE Description IN ('Propia', 'Alquiler');");
        }
    }
}
