using Adoption.Core.Interface;
using Adoption.Core.Models;

namespace Adoption.Persistence.Repository
{
	public class MaritalStateRepository : Repository<MaritalState> ,IMaritalStateRepository
	{
		private readonly AdoptionContext context;

		public MaritalStateRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}