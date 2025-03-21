using AutoMapper;
using MassTransit;
using rabbit.framework.CQRS;
using rabbit.framework.messaging.Events;
using rabbit.library.authors.application.Data;
using rabbit.library.authors.application.DTOs;
using rabbit.library.authors.domain.Models;
using rabbit.library.authors.domain.ValueObjects;

namespace rabbit.library.authors.application.Authors.Commands.CreateAuthor;
public class CreateAuthorCommandHandler
(IApplicationDbContext dbContext, IPublishEndpoint publishEndpoint, IMapper mapper)
: ICommandHandler<CreateAuthorCommand, CreateAuthorResult>
{
  public async Task<CreateAuthorResult> Handle(CreateAuthorCommand command, CancellationToken cancellationToken)
  {
    var author = CreateNewAuthor(command.Author);
    dbContext.Authors.Add(author);
    await dbContext.SaveChangesAsync(cancellationToken);

    var eventMessage = mapper.Map<AuthorEvent>(command.Author);

    await publishEndpoint.Publish(eventMessage, cancellationToken);

    return new CreateAuthorResult(author.Id.Value);
  }

  private Author CreateNewAuthor(AuthorDto author)
  {
    AuthorName? authorName = AuthorName.Of
      (
        author.AuthorName.FirstName,
        author.AuthorName.LastName
      );

    AuthorPhoneNumber? authorPhoneNumber = AuthorPhoneNumber.Of
      (
        author.AuthorPhone.PhoneNumber
      );

    return Author.Create
    (
      authorId: AuthorId.Of(Guid.NewGuid()),
      authorName: authorName,
      authorPhoneNumber: authorPhoneNumber,
      email: author.Email,
      true
    );
  }
}

