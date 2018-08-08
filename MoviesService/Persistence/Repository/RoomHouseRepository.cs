using Adoption.Core.Interface;
using Adoption.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adoption.Persistence.Repository
{
	public class RoomHouseRepository : Repository<RoomHouse>, IRoomHouseRepository
	{
		private readonly AdoptionContext context;

		public RoomHouseRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}