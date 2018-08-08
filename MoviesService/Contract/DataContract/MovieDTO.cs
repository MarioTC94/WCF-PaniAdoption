using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviesService.Contract.DataContract
{

    [DataContract]
    public class MovieDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]

        public CategoryDTO Category { get; set; }

        [DataMember]

        public int CategoryId { get; set; }
    }
}