using rabbit.library.authors.domain.Abstractions;
using rabbit.library.authors.domain.ValueObjects;

namespace rabbit.library.authors.domain.Entities;
public class Author : Aggregate<AuthorId>
{
  public string Name { get; set; }
  public string LastName { get; set; }
}