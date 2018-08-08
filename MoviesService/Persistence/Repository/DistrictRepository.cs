using Adoption.Core.Interface;
using Adoption.Core.Models;

namespace Adoption.Persistence.Repository
{
	public class DistrictRepository : Repository<District>, IDistrictRepository{

		private readonly AdoptionContext context;
		public DistrictRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}