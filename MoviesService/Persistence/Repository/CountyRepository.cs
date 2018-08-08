using Adoption.Core.Interface;
using Adoption.Core.Models;


namespace Adoption.Persistence.Repository
{
	public class CountyRepository : Repository<County>, ICountyRepository
	{

		private readonly AdoptionContext context;
		public CountyRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}