using Adoption.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adoption.Core.Interface
{
	public interface IProvinceRepository : IRepository<Province>{

		IEnumerable<Province> GetProvinceWithRelatives();

		Task<List<Province>> GetProvinceWithRelativesAsync();
	}
}
