namespace rabbit.library.authors.application.DTOs;
public record AuthorDto
(
  AuthorNameDto AuthorName,
  AuthorPhoneDto AuthorPhone,
  string Email,
  bool IsActive
);