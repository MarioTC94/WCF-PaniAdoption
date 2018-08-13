using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Core.Models
{
	public class User
	{
		
		public string Email { get; set; }

		[Required]
		[StringLength(30)]
		public string Name { get; set; }

		[Required]
		[StringLength(30)]
		public string FirstLastName { get; set; }

		[Required]
		[StringLength(30)]
		public string SecondLastName { get; set; }

		[Required]
		[StringLength(20)]
		public string Password { get; set; }
	}
}