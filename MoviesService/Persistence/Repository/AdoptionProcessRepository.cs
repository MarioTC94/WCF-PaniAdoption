using Adoption.Core.Interface;
using Adoption.Core.Models;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Adoption.Persistence.Repository
{
	public class AdoptionProcessRepository : Repository<AdoptionProcess> ,IAdoptionProcessRepository
	{

		private readonly AdoptionContext context;
		public AdoptionProcessRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}

		public AdoptionProcess GetAdoptionWithRelatives(int id)
		{
			return GetQueryWithRelatives()
				.FirstOrDefault(ap => ap.Id == id);
		}

		public ICollection<AdoptionProcess> GetAdoptionWithRelatives()
		{
			return GetQueryWithRelatives()
				.ToList();
		}

		private IQueryable<AdoptionProcess> GetQueryWithRelatives()
		{
			return context.AdoptionProcesses
				.Include(ap => ap.StateFile)
				.Include(ap => ap.MarriageInformation.RoomHouse)
				.Include(ap => ap.MarriageInformation.MaritalState)
				.Include(ap => ap.MarriageInformation.Father.JobInformation.Select(j => j.WorkerType))
				.Include(ap => ap.MarriageInformation.Mother.JobInformation.Select(j => j.WorkerType))
				.Include(ap => ap.MarriageInformation.Father.PersonType)
				.Include(ap => ap.MarriageInformation.Mother.PersonType);
		}
	}
}