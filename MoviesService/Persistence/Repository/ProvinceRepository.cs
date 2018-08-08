using Adoption.Core.Interface;
using Adoption.Core.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Adoption.Persistence.Repository
{
	public class ProvinceRepository : Repository<Province>, IProvinceRepository
	{

		private readonly AdoptionContext context;

		public ProvinceRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}

		public IEnumerable<Province> GetProvinceWithRelatives()
		{
			return context.Provinces
				.Include(p => p.Counties.Select(c => c.Districts)).ToList();
		}
	}
}