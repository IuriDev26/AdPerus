using AdPerus.Domain.SharedContext.Exceptions.Abstractions;

namespace AdPerus.Domain.SalesContext.Exceptions.SaleOrderExceptions;

public sealed class InvalidSaleOrderProductsException(string message) : DomainException(message)
{
    public static void ThrowIfInvalid(List<Entities.Product> products)
    {
        if (products.Count == 0)
            throw new InvalidSaleOrderProductsException("O pedido deve conter pelo menos um produto.");
        
        if (products.Sum(p => p.TotalPrice) <= 0)
            throw new InvalidSaleOrderProductsException("A quantidade de produtos deve ser maior que zero.");
    }
}