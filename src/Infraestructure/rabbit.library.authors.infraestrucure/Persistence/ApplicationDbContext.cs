using Microsoft.EntityFrameworkCore;
using rabbit.library.authors.application.Data;
using rabbit.library.authors.domain.Models;

namespace rabbit.library.authors.infraestrucure.Persistence;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
  public DbSet<Author> Authors { get; set; }
  public DbSet<Book> Books { get; set; }
  public DbSet<AuthorBook> AuthorBooks { get; set; }

  public ApplicationDbContext(DbContextOptions options) : base(options)
  {
    
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
  }
}