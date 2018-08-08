using Adoption.Core.Interface;
using Adoption.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adoption.Persistence.Repository
{
	public class PersonTypeRepository : Repository<PersonType>, IPersonTypeRepository
	{
		private readonly AdoptionContext context;

		public PersonTypeRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}