﻿using System.Text.RegularExpressions;

namespace rabbit.library.authors.domain.ValueObjects;
public partial record AuthorPhoneNumber
{
  private const int DefaultLenght = 8;
  private const string Pattern = @"^(?:-*\d-*){8}$";

  public string Value { get; set; }
  public AuthorPhoneNumber(string value) => Value = value;

  public static AuthorPhoneNumber? Of(string value)
  {
    if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) || value.Length != DefaultLenght)
      return null;

    return new AuthorPhoneNumber(value);
  }

  [GeneratedRegex(Pattern)]
  private static partial Regex PhoneNumberRegex();
}