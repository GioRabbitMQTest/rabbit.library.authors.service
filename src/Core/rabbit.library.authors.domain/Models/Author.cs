using rabbit.library.authors.domain.Abstractions;
using rabbit.library.authors.domain.ValueObjects;

namespace rabbit.library.authors.domain.Models;
public class Author : AggregateRoot<AuthorId>
{
  private readonly List<AuthorBook> _authorBooks = new();
  public IReadOnlyList<AuthorBook> AuthorBooks => _authorBooks.AsReadOnly();
  public AuthorName AuthorName { get; private set; } = default!;
  public AuthorPhoneNumber AuthorPhoneNumber { get; private set; } = default!;
  public string Email { get; private set; }
  public bool IsActive { get; private set; }

  public static Author Create(AuthorId authorId, AuthorName authorName, AuthorPhoneNumber authorPhoneNumber, string email, bool isActive)
  {
    Author author = new()
    {
      Id = authorId,
      AuthorName = authorName,
      AuthorPhoneNumber = authorPhoneNumber,
      Email = email,
      IsActive = isActive
    };

    return author;
  }
}