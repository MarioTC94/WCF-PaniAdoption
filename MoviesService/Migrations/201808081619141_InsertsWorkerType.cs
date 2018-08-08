namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertsWorkerType : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO WorkerTypes(DescriptionWorkerType) VALUES ('Independiente')");
			Sql("INSERT INTO WorkerTypes(DescriptionWorkerType) VALUES ('Empleado')");
			Sql("INSERT INTO WorkerTypes(DescriptionWorkerType) VALUES ('Jubilado')");
			Sql("INSERT INTO WorkerTypes(DescriptionWorkerType) VALUES ('Otro')");
		}
        
        public override void Down()
        {
			Sql("Delete FROM WorkerTypes WHERE DescriptionworkerType IN ('Independiente', 'Empleado', 'Jubilado', 'Otro')");
        }
    }
}
