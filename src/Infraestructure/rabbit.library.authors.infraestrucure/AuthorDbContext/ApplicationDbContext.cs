using Microsoft.EntityFrameworkCore;
using rabbit.library.authors.domain.Entities;

namespace rabbit.library.authors.infraestrucure.AuthorDbContext;
public class ApplicationDbContext : DbContext
{
  public DbSet<Author> MyProperty { get; set; }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
  }
}