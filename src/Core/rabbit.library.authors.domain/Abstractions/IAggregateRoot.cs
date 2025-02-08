using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbit.library.authors.domain.Abstractions;
public interface IAggregateRoot<T> : IAggregateRoot
{

}

public interface IAggregateRoot
{
  IReadOnlyList<IDomainEvent> DomainEvents { get; }
  IDomainEvent[] ClearDomainEvents();
}