using MediatR;
using Microsoft.AspNetCore.Mvc;
using rabbit.library.authors.application.Authors.Commands.CreateAuthor;

namespace rabbit.library.authors.api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AuthorController : ControllerBase
{
  private readonly IMediator mediator;

  public AuthorController(IMediator mediator)
  {
    this.mediator = mediator;
  }

  [HttpPost]
  [ProducesResponseType(201)]
  [ProducesResponseType(400)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public async Task<ActionResult> Post([FromBody] CreateAuthorCommand command)
  {
    var result = await mediator.Send(command);
    return Ok(result);
  }
}