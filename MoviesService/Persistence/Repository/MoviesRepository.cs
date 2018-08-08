using MoviesService.Core.Interface;
using MoviesService.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesService.Persistence.Repository
{
    public class MoviesRepository : Repository<Movie>, IMoviesRepository
    {
        private readonly MoviesShopContext context;

        public MoviesRepository(MoviesShopContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Movie> GetMoviesWithCategory()
        {
            return context.Movies
                .Include(mv => mv.Category)
                .OrderBy(mv => mv.Name)
                .AsEnumerable();
        }
    }
}