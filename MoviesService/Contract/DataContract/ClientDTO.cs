using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesService.Contract.DataContract
{
    public class ClientDTO
    {
        public ClientDTO()
        {
            Movies = new List<MovieDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public IEnumerable<MovieDTO> Movies { get; set; }
    }
}