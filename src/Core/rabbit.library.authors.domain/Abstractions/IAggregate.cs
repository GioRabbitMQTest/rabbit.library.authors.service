namespace rabbit.library.authors.domain.Abstractions;
public interface IAggregate<T> : IAggregate
{
}

public interface IAggregate
{
  IReadOnlyList<IDomainEvent> DomainEvents { get; }
  IDomainEvent[] ClearDomainEvents();
}