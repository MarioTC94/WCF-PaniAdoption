namespace MoviesService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Movies", "Description", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
        }
    }
}
