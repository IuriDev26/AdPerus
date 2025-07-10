using AdPerus.Domain.SharedContext.Exceptions.Abstractions;

namespace AdPerus.Domain.SalesContext.Exceptions.Product;

public sealed class InvalidProductDescriptionException(string message) : DomainException(message)
{
    public static void ThrowIfInvalid(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new InvalidProductDescriptionException("A Descrição do produto não pode ser vazia.");
        
    }
}