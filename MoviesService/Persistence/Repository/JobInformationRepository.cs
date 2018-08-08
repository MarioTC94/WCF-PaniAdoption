using Adoption.Core.Interface;
using Adoption.Core.Models;

namespace Adoption.Persistence.Repository
{
	public class JobInformationRepository : Repository<JobInformation> ,IJobInformationRepository{

		private readonly AdoptionContext context;
		public JobInformationRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}