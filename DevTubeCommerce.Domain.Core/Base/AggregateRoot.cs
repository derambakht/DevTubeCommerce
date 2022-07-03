using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Base
{
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    {
        //private readonly IMediator mediator;

        //public AggregateRoot(IMediator mediator)
        //{
        //    this.mediator = mediator;
        //}

        //public AggregateRoot()
        //{

        //}
       

        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents?.AsReadOnly();

        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<IDomainEvent>();
            _domainEvents.Add(domainEvent);
            //publish
            //1 => get IMeditR from HttpContext

            //2 => Global Class Utility => Event Publish 


            //
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        private List<IDomainEvent> _domainEvents;
       
    }
}
