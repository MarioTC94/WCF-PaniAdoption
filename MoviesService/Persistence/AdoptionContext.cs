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
		public DbSet<Address> Addresses { get; set; }
		public DbSet<WorkerType> WorkerTypes { get; set; }
		public DbSet<JobInformation> JobInformation { get; set; }
		public DbSet<RoomHouse> RoomHouses { get; set; }
		public DbSet<MaritalState> MaritalStates { get; set; }
		public DbSet<StateFile> StateFiles { get; set; }
		public DbSet<AdoptionProcess> AdoptionProcesses { get; set; }

		public AdoptionContext() : base("DefaultConnectionString") { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Province>()
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

			modelBuilder.Entity<Address>()
				.HasRequired(a => a.Province)
				.WithMany()
				.HasForeignKey(ad => ad.ProvinceId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Address>()
				.HasRequired(a => a.County)
				.WithMany()
				.HasForeignKey(ad => ad.CountyId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Address>()
				.HasRequired(a => a.District)
				.WithMany()
				.HasForeignKey(ad => ad.DistrictId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<JobInformation>()
				.Property(pe => pe.AnualSalary)
				.HasPrecision(10, 2);

			modelBuilder.Entity<MarriageInformation>()
				.HasRequired(m => m.Father)
				.WithMany(x => x.Fathers)
				.HasForeignKey(mi => mi.FatherId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<MarriageInformation>()
				.HasRequired(m => m.Mother)
				.WithMany(x => x.Mothers)
				.HasForeignKey(mi => mi.MotherId)
				.WillCascadeOnDelete(false);
			// Ya quedó listo, revice la base y borre este comentario :v
		}

	}
}