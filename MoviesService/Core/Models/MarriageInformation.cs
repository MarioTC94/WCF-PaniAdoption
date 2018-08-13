using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class MarriageInformation
	{

		public MarriageInformation()
		{
			this.Addresses = new Collection<Address>();	
			this.AdoptionProcesses = new Collection<AdoptionProcess>();
		}

		public int Id { get; set; }

		[Required]
		public DateTime MarriageDate { get; set; }

		public MaritalState MaritalState { get; set; }

		[Required]
		public int MaritalStateId { get; set; }

		public RoomHouse RoomHouse { get; set; }

		[Required]
		public int RoomHouseId { get; set; }

		public Person Mother { get; set; }

		[Required]
		public string MotherId { get; set; }

		public Person Father { get; set; }

		[Required]
		public string FatherId { get; set; }

		public ICollection<AdoptionProcess> AdoptionProcesses { get; set; }

		public ICollection<Address> Addresses { get; set; }
	}
}