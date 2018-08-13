namespace Adoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertFileState : DbMigration
    {
		public override void Up()
		{
			Sql("INSERT INTO StateFiles(Description) VALUES ('Iniciado');");
			Sql("INSERT INTO StateFiles(Description) VALUES ('En Proceso');");
			Sql("INSERT INTO StateFiles(Description) VALUES ('Aprobado');");
			Sql("INSERT INTO StateFiles(Description) VALUES ('Rechazado');");
		}

		public override void Down()
		{
			Sql("DELETE FROM StateFiles WHERE Description IN ('Iniciado','En Proceso', 'Aprobado', 'Rechazado');");
		}
	}
}
