using Adoption.Core.Models;
using System.Collections.Generic;

namespace Adoption.Core.Interface
{
	public interface IProvinceRepository : IRepository<Province>{

		IEnumerable<Province> GetProvinceWithRelatives();
	}
}
