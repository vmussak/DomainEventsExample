using DomainEventsExample.DomainEvent.Events;

namespace DomainEventsExample.DomainEvent.Handles 
{ 
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    } 
}





