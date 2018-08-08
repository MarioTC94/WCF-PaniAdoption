using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class District
	{
		
		public District()
		{
			this.Addresses = new Collection<Address>();

		}
		public int Id { get; set; }

		[Required]
		[StringLength(40)]
		public string Name { get; set; }
		public County County { get; set; }

		[Required]
		public int CountyId { get; set; }
		public ICollection<Address> Addresses { get; set; }


	}
}