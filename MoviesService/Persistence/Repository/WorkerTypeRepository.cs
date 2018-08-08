using Adoption.Core.Interface;
using Adoption.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adoption.Persistence.Repository
{
	public class WorkerTypeRepository : Repository<WorkerType>, IWorkerTypeRepository
	{

		private readonly AdoptionContext context;

		public WorkerTypeRepository(AdoptionContext context) : base(context)
		{
			this.context = context;
		}
	}
}