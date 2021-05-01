using Autofac;
using Autofac.Integration.Mvc;
using Store;
using Store.Core.Interfaces;
using Store.Core.Services;
using Store.Infra.Domains;
using Store.Infra.Repositories;
using System.Web.Mvc;

namespace Store.App_Start
{
    public class AutofacConfig
    {
        public static IContainer _container;
        public static void Init()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(WebApiApplication).Assembly);

            builder.RegisterType<SportsService>().InstancePerLifetimeScope();
            builder.RegisterType<BaseContextRepository<CatelogContext>>().As<IEntityContextRepository<IEntityContext>>().InstancePerLifetimeScope();
            builder.RegisterType<CatelogContext>().InstancePerLifetimeScope();



            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(WebApiApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // OPTIONAL: Enable action method parameter injection (RARE).
            //builder.InjectActionInvoker();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}