using Adoption.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Adoption.Persistence
{
    public class AdoptionContext : DbContext
    {

        public DbSet<Person> People { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }

		public DbSet<Province> Provinces { get; set; }

		public DbSet<County> Counties { get; set; }

		public DbSet<District> Districts { get; set; }
		public AdoptionContext() : base("DefaultConnectionString") { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			

			modelBuilder.Entity<Province>()
				.HasKey(p => p.Id)
				.HasKey(p => p.Id)
				.Property(p => p.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			modelBuilder.Entity<County>()
				.HasKey(p => p.Id)
				.Property(p => p.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			modelBuilder.Entity<District>()
				.HasKey(p => p.Id)
				.Property(p => p.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
		}

	}
}