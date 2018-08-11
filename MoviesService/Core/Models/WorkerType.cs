using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class WorkerType
	{
		public WorkerType()
		{
			this.Jobs = new Collection<JobInformation>();
		}
		public int Id { get; set; }

		[Required]
		[StringLength(30)]
		public string Description { get; set; }

		public ICollection<JobInformation> Jobs { get; set; }
	}
}