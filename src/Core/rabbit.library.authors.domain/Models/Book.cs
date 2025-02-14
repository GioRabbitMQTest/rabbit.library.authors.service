using rabbit.library.authors.domain.Abstractions;
using rabbit.library.authors.domain.ValueObjects;

namespace rabbit.library.authors.domain.Models;
public class Book : Entity<BookId>
{
  private List<AuthorBook> _authorBooks = new();
  public IReadOnlyList<AuthorBook> AuthorBooks => _authorBooks.AsReadOnly();

  public string Title { get; private set; }
  public string Synopsis { get; private set; }
}