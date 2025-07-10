using AdPerus.Domain.SharedContext.Exceptions.Abstractions;

namespace AdPerus.Domain.SalesContext.Exceptions.Product;

public sealed class InvalidProductTitleException(string message) : DomainException(message)
{
    public static void ThrowIfInvalid(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new InvalidProductTitleException("The title is invalid.");
    }
}