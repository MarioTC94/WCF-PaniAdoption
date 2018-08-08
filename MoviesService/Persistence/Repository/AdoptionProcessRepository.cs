using Adoption.Core.Interface;
using Adoption.Core.Models;


namespace Adoption.Persistence.Repository
{
	public class AdoptionProcessRepository : Repository<AdoptionProcess> ,IAdoptionProcessRepository
	{

		private readonly AdoptionContext context;
		public AdoptionProcessRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}