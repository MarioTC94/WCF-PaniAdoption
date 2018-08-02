using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Adoption.Core.Models
{
	public class PersonType{

		public PersonType()
		{
			this.People = new Collection<Person>();
		}

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Description { get; set; }
        public ICollection<Person> People { get; set; }
    }
}