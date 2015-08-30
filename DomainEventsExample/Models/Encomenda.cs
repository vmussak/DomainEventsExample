using System;

namespace DomainEventsExample.Models
{
    public class Encomenda
    {
        public Encomenda(int clienteId, int objetoId)
        {
            ClienteId = clienteId;
            ObjetoId = objetoId;
        }

        public Encomenda(int clienteId, int objetoId, DateTime dataEntregaPrevista)
        {
            ClienteId = clienteId;
            ObjetoId = objetoId;
            DataEntregaPrevista = dataEntregaPrevista;
        }

        public int ClienteId { get; }
        public int ObjetoId { get; }
        public DateTime DataEntregaPrevista { get; } = DateTime.Now.AddDays(7);
    }
}
