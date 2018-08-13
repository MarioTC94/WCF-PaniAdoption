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
        public virtual DbSet<Person> People { get; set; }
		public virtual DbSet<PersonType> PersonTypes { get; set; }
		public virtual DbSet<Province> Provinces { get; set; }
		public virtual DbSet<County> Counties { get; set; }
		public virtual DbSet<District> Districts { get; set; }
		public virtual DbSet<Address> Addresses { get; set; }
		public virtual DbSet<WorkerType> WorkerTypes { get; set; }
		public virtual DbSet<JobInformation> JobInformation { get; set; }
		public virtual DbSet<RoomHouse> RoomHouses { get; set; }
		public virtual DbSet<MaritalState> MaritalStates { get; set; }
		public virtual DbSet<StateFile> StateFiles { get; set; }
		public virtual DbSet<AdoptionProcess> AdoptionProcesses { get; set; }
		public virtual DbSet<MarriageInformation> MarriageInformation { get; set; }

		public virtual DbSet<User> Users { get; set; }

		public AdoptionContext() : base("AzureConnectionString") { }

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
				.WithMany(a => a.Addresses)
				.HasForeignKey(ad => ad.ProvinceId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Address>()
				.HasRequired(a => a.County)
				.WithMany(a => a.Addresses)
				.HasForeignKey(ad => ad.CountyId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Address>()
				.HasRequired(a => a.District)
				.WithMany(a => a.Addresses)
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

			modelBuilder.Entity<User>()
				.HasKey(u => u.Email);
		}

	}
}