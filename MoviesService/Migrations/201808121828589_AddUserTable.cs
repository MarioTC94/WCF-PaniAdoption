namespace Adoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 30),
                        FirstLastName = c.String(nullable: false, maxLength: 30),
                        SecondLastName = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
