using Adoption.Contract;
using Adoption.Core.Interface;
using Adoption.Persistence;
using Adoption.Persistence.Repository;
using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Web;

namespace MoviesService
{
	public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            InitializeAutofac();
            InitializeMapper();
        }

        private void InitializeAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
			builder.RegisterType<AdoptionContext>();
			builder.RegisterType<AddressServices>();
			builder.RegisterType<AdoptionsServices>();
			builder.RegisterType<WorkerTypeServices>();
			builder.RegisterType<RoomHouseServices>();
			builder.RegisterType<MaritalStateServices>();
			builder.RegisterType<StateFileServices>();
            AutofacHostFactory.Container = builder.Build();
        }

        private void InitializeMapper()
        {
            AutoMapper.Mapper.Initialize(cfg => {
                cfg.AddProfile<MappingProfile>();
            });
        }
    }
}