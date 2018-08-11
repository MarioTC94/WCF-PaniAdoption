namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertWorkerType : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO WorkerTypes(Description) VALUES ('Independiente');");
			Sql("INSERT INTO WorkerTypes(Description) VALUES ('Empleado');");
			Sql("INSERT INTO WorkerTypes(Description) VALUES ('Jubilado');");
			Sql("INSERT INTO WorkerTypes(Description) VALUES ('Otro');");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM WokerTypes WHERE Description IN ('Independiente', 'Empleado', 'Jubilado', 'Otro')");
        }
    }
}
