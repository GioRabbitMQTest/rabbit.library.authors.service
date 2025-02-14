using rabbit.library.authors.domain.Abstractions;
using rabbit.library.authors.domain.ValueObjects;

namespace rabbit.library.authors.domain.Models;
public class AuthorBook
{
  public Author Author { get; private set; }
  public AuthorId AuthorId { get; private set; } = default!;

  public Book Book { get; private set; }
  public BookId BookId { get; private set; } = default!;
}