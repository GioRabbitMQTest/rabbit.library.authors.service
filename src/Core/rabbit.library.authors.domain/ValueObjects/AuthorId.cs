using rabbit.library.authors.domain.Exceptions;

namespace rabbit.library.authors.domain.ValueObjects;
public class AuthorId
{
  public Guid Value { get; }
  private AuthorId(Guid value) => Value = value;

  public static AuthorId Of(Guid value)
  {
    ArgumentNullException.ThrowIfNull(value);
    if (value == Guid.Empty)
      throw new DomainException("Author Id can't be empty");

    return new AuthorId(value);
  }
}