﻿
namespace rabbit.library.authors.domain.Abstractions;
public class AggregateRoot<Tid> : Entity<Tid>, IAggregateRoot
{
  private readonly List<IDomainEvent> _domainEvents = new();
  public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

  public void AddDomainEvent(IDomainEvent domainEvent)
  {
    _domainEvents.Add(domainEvent);
  }

  public IDomainEvent[] ClearDomainEvents()
  {
    IDomainEvent[] dequeuedEvents = _domainEvents.ToArray();
    _domainEvents.Clear();
    return dequeuedEvents;
  }
}