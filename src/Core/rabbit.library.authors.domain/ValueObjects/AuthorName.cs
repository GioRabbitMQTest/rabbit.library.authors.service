﻿namespace rabbit.library.authors.domain.ValueObjects;
public class AuthorName
{
  public string FirstName { get; set; }
  public string LastName { get; set; }

  public AuthorName(string firstName, string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
  }

  public static AuthorName? Create(string firstName, string lastName)
  {
    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
      return null;

    return new AuthorName(firstName, lastName);
  }
}