using Adoption.Core.Models;
using System.Collections.Generic;

namespace Adoption.Core.Interface
{
	public interface IPersonRepository : IRepository<Person>
	{
		IEnumerable<Person> GetTypePerson();
	}
}
