using Adoption.Core.Models;
using System.Collections.Generic;

namespace Adoption.Core.Interface
{
	public interface IAdoptionProcessRepository : IRepository<AdoptionProcess>{

		AdoptionProcess GetAdoptionWithRelatives(int id);
		ICollection<AdoptionProcess> GetAdoptionWithRelatives();
	}
}
