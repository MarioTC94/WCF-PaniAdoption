using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class JobInformation
	{
		public int Id { get; set; }

		[Required]
		[StringLength(20)]
		public string CompanyName { get; set; }

		[Required]
		[StringLength(20)]
		public string ActualPosition { get; set; }

		[Required]
		public Decimal AnualSalary { get; set; }

		[Required]
		[StringLength(20)]
		public string Phone { get; set; }

		[Required]
		[StringLength(300)]
		public string AddressCompany { get; set; }

		public WorkerType WorkerType { get; set; }

		[Required]
		public int WorkerTypeId { get; set; }

		public Person Person { get; set; }

		public string PersonId { get; set; }
	}
}