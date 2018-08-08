using MoviesService.Contract.DataContract;
using MoviesService.Core.Interface;
using MoviesService.Core.Models;
using System.Collections.Generic;

namespace MoviesService.Contract
{
    public class MoviesServices : IMoviesServices
    {
        private readonly IUnitOfWork uow;

        public MoviesServices(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public void AddMovie(MovieDTO movie)
        {
            var movieToSave = AutoMapper.Mapper.Map<Movie>(movie);
            uow.Movies.Add(movieToSave);
            uow.SaveChanges();
        }

        public IEnumerable<MovieDTO> GetAllMovies()
        {
            var movies = uow.Movies.GetAll();
            return AutoMapper.Mapper.Map<IEnumerable<MovieDTO>>(movies);
        }

        public IEnumerable<ClientDTO> GetClients()
        {
            var clients = uow.Client.GetClientWithMoviesAndCategory();
            return AutoMapper.Mapper.Map<IEnumerable<ClientDTO>>(clients);
        }
    }
}
