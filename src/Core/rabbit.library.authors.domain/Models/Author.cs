using rabbit.library.authors.domain.Abstractions;
using rabbit.library.authors.domain.ValueObjects;

namespace rabbit.library.authors.domain.Models;
public class Author : AggregateRoot<AuthorId>
{
  public AuthorId AuthorId { get; private set; } = default!;
  public AuthorName AuthorName { get; private set; } = default!;
}