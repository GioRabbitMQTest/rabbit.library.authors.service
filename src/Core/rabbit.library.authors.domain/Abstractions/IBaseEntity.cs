namespace rabbit.library.authors.domain.Abstractions;
public interface IBaseEntity<T>
{
  public T Id { get; set; }
}