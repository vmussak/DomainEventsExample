using DomainEventsExample.DomainEvent.Handles;
using SimpleInjector;
using SimpleInjector.Extensions;

namespace DomainEventsExample.DependencyResolver
{ 
    public static class SimpleInjectorContainer
    {

        private static readonly Container _container;

        static SimpleInjectorContainer()
        {
            _container = new Container();
        }

        public static Container RegisterServices()
        {
             _container.RegisterCollection(typeof(IHandle<>), typeof(IHandle<>).Assembly);

            _container.Verify();
            return _container;
        }

        public static Container GetContainer()
        {
            return _container;
        }
    }
}
