using rabbit.library.authors.domain.Exceptions;

namespace rabbit.library.authors.domain.ValueObjects;
public record AuthorBookId
{
  public Guid Value { get; }
  public AuthorBookId(Guid value) => Value = value;
  public static AuthorBookId Of(Guid value)
  {
    ArgumentNullException.ThrowIfNull(value);

    if (value == Guid.Empty)
      throw new DomainException("AuthorBook Id can't be emty");

    return new AuthorBookId(value);
  }
}