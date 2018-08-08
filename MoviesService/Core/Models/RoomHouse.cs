using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adoption.Core.Models
{
	public class RoomHouse
	{
		public RoomHouse()
		{
			this.Marriages = new Collection<MarriageInformation>();
		}

		public int Id { get; set; }

		[Required]
		[StringLength(30)]
		public string Description { get; set; }

		public ICollection<MarriageInformation> Marriages { get; set; }
	}
}