using Adoption.Contract;
using Adoption.Core.Interface;
using Adoption.Core.Models;
using System.Collections.Generic;

namespace Adoption.Contract
{
    public class AdoptionsServices : IAdoptionServices
    {
        private readonly IUnitOfWork uow;

        public AdoptionsServices(IUnitOfWork uow)
        {
            this.uow = uow;
        }

    }
}
