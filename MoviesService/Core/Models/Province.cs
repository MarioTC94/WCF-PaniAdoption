﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class Province
	{
		public Province()
		{
			this.Counties = new Collection<County>();
			this.Addresses = new Collection<Address>();
		}

		public int Id { get; set; }

		[Required]
		[StringLength(32)]
		public string Name { get; set; }

		public ICollection<County> Counties { get; set; }

		public ICollection<Address> Addresses { get; set; }
	}
}