using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adoption.Core.Models
{
	public class AdoptionProcess
	{

		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string ProcessDescripction { get; set; }

		[Required]
		public bool AllDocuments { get; set; }

		[Required]
		public bool ParentsInterview { get; set; }

		[Required]
		public bool FamilyVisit { get; set; }

		[Required]
		[StringLength(15)]
		public string IDKid { get; set; }

		public StateFile StateFile { get; set; }

		[Required]
		public int StateFileId { get; set; }

		public MarriageInformation MarriageInformation { get; set; }

		[Required]
		public int MarriageInformationId { get; set; }


	}
}