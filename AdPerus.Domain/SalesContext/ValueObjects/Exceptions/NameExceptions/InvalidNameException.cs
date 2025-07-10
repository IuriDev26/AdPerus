using AdPerus.Domain.SharedContext.Exceptions.Abstractions;

namespace AdPerus.Domain.SalesContext.ValueObjects.Exceptions.NameExceptions;

public class InvalidNameException(string message) : DomainException(message)
{
    public static void ThrowIfInvalid(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            throw new InvalidNameException("O nome não pode ser vazio.");
            
    }
}