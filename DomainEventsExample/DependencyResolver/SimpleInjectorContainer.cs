using DomainEventsExample.DomainEvent.Handles;
using SimpleInjector;
using SimpleInjector.Extensions;

namespace DomainEventsExample.DependencyResolver
{ 
    public static class SimpleInjectorContainer
    {
        static SimpleInjectorContainer()
        {
            Container = new Container();
        }

        private static readonly Container Container;

        public static Container RegisterServices()
        {
            Container.RegisterManyForOpenGeneric(typeof(IHandle<>),
                (serviceType, implementationTypes) => Container.RegisterAll(serviceType, implementationTypes),
                typeof(IHandle<>).Assembly);

            Container.Verify();
            return Container;
        }

        public static Container GetContainer()
        {
            return Container;
        }
    }
}