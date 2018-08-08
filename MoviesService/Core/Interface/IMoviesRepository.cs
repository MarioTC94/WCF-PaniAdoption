using MoviesService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesService.Core.Interface
{
    public interface IMoviesRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetMoviesWithCategory();
    }
}
