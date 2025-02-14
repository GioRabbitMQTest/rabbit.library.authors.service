using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rabbit.library.authors.domain.Models;
using rabbit.library.authors.domain.ValueObjects;

namespace rabbit.library.authors.infraestrucure.Persistence.Configurations;
public class BookConfiguration : IEntityTypeConfiguration<Book>
{
  public void Configure(EntityTypeBuilder<Book> builder)
  {
    builder.HasKey(x => x.Id);

    builder.Property(x => x.Id)
      .HasConversion
      (
        bookId => bookId.Value,
        dbId => BookId.Of(dbId)
      );

    builder.Property(x => x.Title)
      .HasMaxLength(50)
      .IsRequired();

    builder.Property(x => x.Synopsis)
      .HasMaxLength(200)
      .IsRequired();

    builder.HasMany(x => x.AuthorBooks)
      .WithOne(ab => ab.Book)
      .HasForeignKey(ab => ab.BookId)
      .OnDelete(DeleteBehavior.Cascade);
  }
}