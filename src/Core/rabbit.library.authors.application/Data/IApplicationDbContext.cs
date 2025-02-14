using Microsoft.EntityFrameworkCore;
using rabbit.library.authors.domain.Models;

namespace rabbit.library.authors.application.Data;
public interface IApplicationDbContext
{
  DbSet<Author> Authors { get; set; }
  DbSet<Book> Books { get; set; }
  DbSet<AuthorBook> AuthorBooks { get; set; }
  Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}