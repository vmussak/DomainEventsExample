using DomainEventsExample.DependencyResolver;
using DomainEventsExample.DomainEvent.Events;
using DomainEventsExample.DomainEvent.Handles;

namespace DomainEventsExample.DomainEvent
{ 
    public static class DomainEvents
    {
        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            var handles = SimpleInjectorContainer.GetContainer().GetAllInstances<IHandle<T>>();

            foreach (var handle in handles)
                handle.Handle(evento);
        }
    }
} 






