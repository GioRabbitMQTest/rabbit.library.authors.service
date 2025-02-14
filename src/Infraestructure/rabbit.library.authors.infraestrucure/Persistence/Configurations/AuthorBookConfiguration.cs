using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rabbit.library.authors.domain.Models;

namespace rabbit.library.authors.infraestrucure.Persistence.Configurations;
public class AuthorBookConfiguration : IEntityTypeConfiguration<AuthorBook>
{
  public void Configure(EntityTypeBuilder<AuthorBook> builder)
  {
    builder.HasKey(ab => new { ab.AuthorId, ab.BookId });

    builder.HasOne(x => x.Author)
      .WithMany(x => x.AuthorBooks)
      .HasForeignKey(ab => ab.AuthorId);

    builder.HasOne(ab => ab.Book)
      .WithMany(ab => ab.AuthorBooks)
      .HasForeignKey(ab => ab.BookId);
  }
}