namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfoStateFile : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO StateFiles(Description) VALUES('Iniciado');");
			Sql("INSERT INTO StateFiles(Description) VALUES('En Proceso');");
			Sql("INSERT INTO StateFiles(Description) VALUES('Finalizado');");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM StateFiles");
        }
    }
}
