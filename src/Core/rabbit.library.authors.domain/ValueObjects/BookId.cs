using rabbit.library.authors.domain.Exceptions;

namespace rabbit.library.authors.domain.ValueObjects;
public record BookId
{
  public Guid Value { get; set; }
  public BookId(Guid value) => Value = value;
  public static BookId Of(Guid value)
  {
    ArgumentNullException.ThrowIfNull(value);

    if (value == Guid.Empty)
      throw new DomainException("BookId can't be empty");

    return new BookId(value);
  }
}