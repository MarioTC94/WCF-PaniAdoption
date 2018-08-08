using Adoption.Core.Interface;
using Adoption.Core.Models;


namespace Adoption.Persistence.Repository
{
	public class AddressRepository : Repository<Address>, IAddressRepository
	{
		private readonly AdoptionContext context;

		public AddressRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}