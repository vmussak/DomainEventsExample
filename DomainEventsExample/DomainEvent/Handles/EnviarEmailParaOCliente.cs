using DomainEventsExample.DomainEvent.Events;
using System;

namespace DomainEventsExample.DomainEvent.Handles
{
    public class EnviarEmailParaOCliente : IHandle<EncomendaRealizada>
    {
        public void Handle(EncomendaRealizada args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Email para o cliente enviado!");
        }
    }
}
