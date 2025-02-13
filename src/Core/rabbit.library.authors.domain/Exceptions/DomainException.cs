namespace rabbit.library.authors.domain.Exceptions;
public class DomainException : Exception
{
  public DomainException(string message) : base($"Domain exception {message}")
  {
    
  }
}