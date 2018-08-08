using MoviesService.Core.Interface;
using MoviesService.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesService.Persistence.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly MoviesShopContext context;

        public ClientRepository(MoviesShopContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Client> GetClientWithMoviesAndCategory()
        {
            return context.Clients
                .Include(cl => cl.Movies
                    .Select(mv => mv.Category))
                .OrderBy(cl => cl.Name)
                .AsEnumerable();
        }
    }
}