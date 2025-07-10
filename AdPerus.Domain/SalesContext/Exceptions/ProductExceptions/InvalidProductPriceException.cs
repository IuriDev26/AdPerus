using AdPerus.Domain.SharedContext.Exceptions.Abstractions;

namespace AdPerus.Domain.SalesContext.Exceptions.Product;

public sealed class InvalidProductPriceException(string message) : DomainException(message)
{
    public static void ThrowIfInvalid(decimal price)
    {
        if (price <= 0)
            throw new InvalidProductPriceException("O preço do produto deve ser maior que zero.");
    }
}