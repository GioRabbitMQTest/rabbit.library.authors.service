using AutoMapper;
using rabbit.framework.messaging.Events;
using rabbit.library.authors.application.DTOs;

namespace rabbit.library.authors.application.MappingProfile;
public class AuthorProfile : Profile
{
  public AuthorProfile()
  {
    CreateMap<AuthorDto, AuthorEvent>()
      .ForMember(authorEvent => authorEvent.FirtName,
      options => options.MapFrom(MapAuthorEventFirstName))
      .ForMember(authorEvent => authorEvent.LastName,
      options => options.MapFrom(MapAuthorEventLastName))
      .ForMember(authorEvent => authorEvent.PhoneNumber,
      options => options.MapFrom(MapAuthorEventPhone));
    CreateMap<AuthorEvent, AuthorDto>();
  }

  private string MapAuthorEventPhone(AuthorDto dto, AuthorEvent authorEvent)
  {
    return dto.AuthorPhone.PhoneNumber;
  }

  private string MapAuthorEventLastName(AuthorDto dto, AuthorEvent authorEvent)
  {
    return dto.AuthorName.LastName;
  }

  private string MapAuthorEventFirstName(AuthorDto dto, AuthorEvent authorEvent)
  {
    return dto.AuthorName.FirstName;
  }
}