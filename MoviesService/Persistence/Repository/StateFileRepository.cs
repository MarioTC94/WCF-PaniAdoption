using Adoption.Core.Interface;
using Adoption.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adoption.Persistence.Repository
{
	public class StateFileRepository : Repository<StateFile>, IStateFileRepository
	{
		private readonly AdoptionContext context;

		public StateFileRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}