using Adoption.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adoption.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AdoptionContext context;

        public UnitOfWork(AdoptionContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || context is null)
            {
                return;
            }

            this.context.Dispose();

        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}