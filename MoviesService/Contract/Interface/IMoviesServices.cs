using MoviesService.Contract.DataContract;
using MoviesService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MoviesService.Contract
{
    [ServiceContract]
    public interface IMoviesServices
    {
        [OperationContract]
        IEnumerable<MovieDTO> GetAllMovies();

        [OperationContract]
        void  AddMovie(MovieDTO movie);

        [OperationContract]
        IEnumerable<ClientDTO> GetClients();

    }
}
