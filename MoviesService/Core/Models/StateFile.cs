
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class StateFile
	{
		public StateFile()
		{
			this.AdoptionProcesses = new Collection<AdoptionProcess>();
		}
		public int Id { get; set; }

		[Required]
		[StringLength(20)]
		public string Description { get; set; }

		ICollection<AdoptionProcess> AdoptionProcesses { get; set; }


	}
}