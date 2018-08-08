using MoviesService.Core.Models;
using System.Collections.Generic;

namespace MoviesService.Core.Interface
{
    public interface IClientRepository : IRepository<Client>
    {
        IEnumerable<Client> GetClientWithMoviesAndCategory();
    }
}
