using rabbit.framework.CQRS;
using rabbit.library.authors.application.DTOs;

namespace rabbit.library.authors.application.Authors.Commands.CreateAuthor;
public record CreateAuthorCommand(AuthorDto Author)
: ICommand<CreateAuthorResult>;