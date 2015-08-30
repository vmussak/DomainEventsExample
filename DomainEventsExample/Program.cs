using DomainEventsExample.DependencyResolver;
using DomainEventsExample.DomainEvent;
using DomainEventsExample.DomainEvent.Events;
using DomainEventsExample.Models;
using System;

namespace DomainEventsExample
{
    class Program
    { 
        static void Main(string[] args) 
        {
            //Resolvendo as dependências
            SimpleInjectorContainer.RegisterServices();

            //Preparando o envento
            var idCliente = 10;
            var idObjeto = 574;
            var encomenda = new Encomenda(idCliente, idObjeto);

            var fazerUmaEncomenda = new EncomendaRealizada(
                encomenda.ClienteId,
                encomenda.ObjetoId,
                encomenda.DataEntregaPrevista
            );

            //Realizando o evento
            DomainEvents.Raise(fazerUmaEncomenda);

            Console.ReadKey();
        }
    } 
} 
