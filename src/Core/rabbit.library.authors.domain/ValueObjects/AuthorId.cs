namespace rabbit.library.authors.domain.ValueObjects;
public class AuthorId
{
  public Guid Value { get; }
  private AuthorId(Guid value) => Value = value;
}