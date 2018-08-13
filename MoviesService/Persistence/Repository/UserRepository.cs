using Adoption.Core.Interface;
using Adoption.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adoption.Persistence.Repository
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		private readonly AdoptionContext context;

		public UserRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}