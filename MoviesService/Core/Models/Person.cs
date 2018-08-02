using System;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class Person{
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
		public string IdentificationNumber { get; set; }

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
		public int PersonTypeId { get; set; }
	}
}