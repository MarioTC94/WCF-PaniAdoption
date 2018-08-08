using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviesService.Contract.DataContract
{
    [DataContract]
    public class CategoryDTO
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public ICollection<MovieDTO> Movies { get; set; }
    }
}