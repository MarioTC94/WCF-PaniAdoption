namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "ClientId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "ClientId");
            AddForeignKey("dbo.Movies", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "ClientId", "dbo.Clients");
            DropIndex("dbo.Movies", new[] { "ClientId" });
            DropColumn("dbo.Movies", "ClientId");
            DropTable("dbo.Clients");
        }
    }
}
