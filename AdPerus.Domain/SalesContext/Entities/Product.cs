using System.Runtime.CompilerServices;
using AdPerus.Domain.SalesContext.Exceptions;
using AdPerus.Domain.SalesContext.Exceptions.Product;
using AdPerus.Domain.SharedContext.Entities.Abstractions;

namespace AdPerus.Domain.SalesContext.Entities;

public sealed class Product : Entity
{
    #region Properties

    public string Title { get; } = null!;
    public string Description { get; } = null!;
    public decimal UnitPrice { get; }
    public int Quantity { get; }
    public decimal TotalPrice => UnitPrice * Quantity;

    #endregion

    #region Constructors

    private Product()
    {
        
    }

    private Product(string title, string description, decimal unitPrice, int quantity)
    {
        Title = title;
        Description = description;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    #endregion

    #region Factories

    public static Product Create(string title, string description, decimal unitPrice, int quantity)
    {
        InvalidProductTitleException.ThrowIfInvalid(title);
        InvalidProductDescriptionException.ThrowIfInvalid(description);
        InvalidProductPriceException.ThrowIfInvalid(unitPrice);
        InvalidProductQuantityException.ThrowIfInvalid(quantity);
        
        return new Product(title, description, unitPrice, quantity);   
    }

    #endregion

    #region Operators

    public static implicit operator string(Product product) => product.ToString();

    #endregion

    #region Overrides

    public override string ToString() => Title;

    #endregion

}