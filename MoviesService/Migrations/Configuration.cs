namespace MoviesService.Migrations
{
	using Adoption.Persistence;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<AdoptionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AdoptionContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
