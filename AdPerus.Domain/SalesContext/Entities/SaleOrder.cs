using AdPerus.Domain.SalesContext.Enums;
using AdPerus.Domain.SalesContext.Exceptions.SaleOrderExceptions;
using AdPerus.Domain.SharedContext.Entities.Abstractions;

namespace AdPerus.Domain.SalesContext.Entities;

public sealed class SaleOrder : Entity
{
    #region Properties

    public Customer Customer { get; set; } = null!;
    public IReadOnlyCollection<Product> Products => _products;
    private readonly List<Product> _products = null!;
    public ESaleOrderStatus Status { get; set; }
    public decimal Amount { get; set; }
    public DateTime? PaidAt { get; set; }

    #endregion

    #region Constructors

    private SaleOrder()
    {
        
    }
    
    private SaleOrder(Customer customer, List<Product> products)
    {
        Customer = customer;
        _products = products;

        Status = ESaleOrderStatus.AwaitingPayment;
        Amount = products.Sum(p => p.TotalPrice);
    }

    #endregion

    #region Factories

    public static SaleOrder Create(Customer customer, List<Product> products)
    {
        InvalidSaleOrderProductsException.ThrowIfInvalid(products);
        return new SaleOrder(customer, products);
    }

    #endregion
}