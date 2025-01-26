namespace rabbit.library.authors.domain.ValueObjects;
public record AuthorId
{
  public Guid Value { get; }
  private AuthorId(Guid value) => Value = value;
}