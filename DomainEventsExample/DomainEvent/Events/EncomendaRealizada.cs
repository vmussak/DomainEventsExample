using System;

namespace DomainEventsExample.DomainEvent.Events
{
    public class EncomendaRealizada : IDomainEvent
    {
        public EncomendaRealizada(int clienteId, int objetoId, DateTime dataEntregaPrevista)
        {
            ClienteId = clienteId;
            ObjetoId = objetoId;
            DataEntregaPrevista = dataEntregaPrevista;
        }

        public int ClienteId { get; }
        public int ObjetoId { get; }
        public DateTime DataEntregaPrevista { get; }
    }
}




