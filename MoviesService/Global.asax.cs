using Autofac;
using Autofac.Integration.Wcf;
using Adoption.Contract;
using Adoption.Core.Interface;
using Adoption.Persistence;
using Adoption.Persistence.Repository;
using System;
using System.Web;

namespace Adoption
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
            builder.RegisterType<AdoptionsServices>();
            builder.RegisterType<AdoptionContext>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
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