using AdPerus.Domain.SharedContext.Exceptions.Abstractions;

namespace AdPerus.Domain.SalesContext.Exceptions.Product;

public sealed class InvalidProductQuantityException(string message) : DomainException(message)
{
    public static void ThrowIfInvalid(int quantity)
    {
        if (quantity <= 0)
            throw new InvalidProductQuantityException("A quantidade do produto deve ser maior que zero.");
    }
}