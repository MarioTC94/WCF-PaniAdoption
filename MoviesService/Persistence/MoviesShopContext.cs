using MoviesService.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesService.Persistence
{
    public class MoviesShopContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public MoviesShopContext() : base("DefaultConnectionString") { }

    }
}