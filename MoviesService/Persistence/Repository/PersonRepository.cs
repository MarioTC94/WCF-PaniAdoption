using Adoption.Core.Interface;
using Adoption.Core.Models;
using System.Collections.Generic;

namespace Adoption.Persistence.Repository
{
	public class PersonRepository : Repository<Person>, IPersonRepository
	{
		private readonly AdoptionContext context;

		public PersonRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}

		public IEnumerable<Person> GetTypePerson()
		{
			throw new System.NotImplementedException();
		}
	}
}