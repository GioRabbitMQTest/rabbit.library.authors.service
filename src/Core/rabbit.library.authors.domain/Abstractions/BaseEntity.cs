namespace rabbit.library.authors.domain.Abstractions;
public abstract class BaseEntity<T> : IBaseEntity<T>
{
  public T Id { get; set; }
}