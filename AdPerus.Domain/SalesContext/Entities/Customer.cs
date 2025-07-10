using AdPerus.Domain.SalesContext.ValueObjects;
using AdPerus.Domain.SharedContext.Entities.Abstractions;

namespace AdPerus.Domain.SalesContext.Entities;

public sealed class Customer : Entity
{
    public Name Name { get; set; }
    public Contact Contact { get; set; }
}