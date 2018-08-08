using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesService.Core.Models
{
    public class Client
    {
        public Client()
        {
            Movies = new List<Movie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}