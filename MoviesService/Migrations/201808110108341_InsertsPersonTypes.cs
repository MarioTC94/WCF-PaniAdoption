namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertsPersonTypes : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO PersonTypes(Description) VALUES ('Padre');");
			Sql("INSERT INTO PersonTypes(Description) VALUES ('Madre');");
		}
        
        public override void Down()
        {
			Sql("DELTE FROM PersonTypes WHERE Description IN ('Padre', 'Madre');");
        }
    }
}
