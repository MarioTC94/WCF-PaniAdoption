using MoviesService.Core.Interface;
using MoviesService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesService.Persistence.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly MoviesShopContext context;

        public CategoryRepository(MoviesShopContext context) : base(context)
        {
            this.context = context;
        }
    }
}