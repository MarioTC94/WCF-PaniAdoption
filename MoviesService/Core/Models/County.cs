using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class County
	{
		public County()
		{
			this.Districts = new Collection<District>();
			this.Addresses = new Collection<Address>();
		}

		public int Id { get; set; }

		[Required]
		[StringLength(20)]
		public string Name { get; set; }
		public Province Province { get; set; }

		[Required]
		public int ProvinceId { get; set; }
		public ICollection<District> Districts { get; set; }

		public ICollection<Address> Addresses { get; set; }
	}
}