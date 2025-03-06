using rabbit.framework.messaging.Events;

namespace rabbit.library.authors.application.Events;
public record AuthorEvent : IntegrationEvent
{
  public string FirtName { get; set; }
  public string LastName { get; set; }
  public string PhoneNumber { get; set; }
  public string Email { get; set; }
  public bool IsActive { get; set; }
}