using DomainEventsExample.DomainEvent.Events;
using System;

namespace DomainEventsExample.DomainEvent.Handles
{
    public class EnviarEmailParaATransportadora : IHandle<EncomendaRealizada>
    {
        public void Handle(EncomendaRealizada args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Email para transportadora enviado!");
        }
    }
}
