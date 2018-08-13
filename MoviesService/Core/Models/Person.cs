using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class Person{

		public Person()
		{
			this.JobInformation = new Collection<JobInformation>();
			this.Fathers = new Collection<MarriageInformation>();
			this.Mothers = new Collection<MarriageInformation>();
		}

        [StringLength(15)]
		public string Id { get; set; }

		[Required]
		[StringLength(30)]
		public string Name { get; set; }

		[Required]
		[StringLength(30)]
		public string LastName { get; set; }

		[Required]
		[StringLength(30)]
		public string SecondLastName { get; set; }

		public DateTime BirthDay { get; set; }

		[Required]
		[StringLength(30)]
		public string Email { get; set; }

		[Required]
		[StringLength(15)]
		public string Phone { get; set; }

		public PersonType PersonType { get; set; }

		[Required]
		public int PersonTypeId { get; set; }

		public ICollection<JobInformation> JobInformation { get; set; }

		public ICollection<MarriageInformation> Fathers { get; set; }

		public ICollection<MarriageInformation> Mothers { get; set; }

	}
}