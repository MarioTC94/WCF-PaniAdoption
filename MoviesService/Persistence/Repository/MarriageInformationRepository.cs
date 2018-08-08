using Adoption.Core.Interface;
using Adoption.Core.Models;

namespace Adoption.Persistence.Repository
{
	public class MarriageInformationRepository : Repository<MarriageInformation>, IMarriageInformationRepository
	{

		private readonly AdoptionContext context;

		public MarriageInformationRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}