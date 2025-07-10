using AdPerus.Domain.SalesContext.ValueObjects.Exceptions.NameExceptions;
using AdPerus.Domain.SharedContext.ValueObjects.Abstractions;

namespace AdPerus.Domain.SalesContext.ValueObjects;

public sealed record Name : ValueObject
{
    #region Properties

    public string FirstName { get; } = null!;
    public string LastName { get; } = null!;

    #endregion

    #region Constructors

    public Name()
    {
        
    }

    public Name(string firstname, string lastName)
    {
        FirstName = firstname;
        LastName = lastName;
    }

    #endregion

    #region Factories

    public static Name Create(string firstname, string lastName)
    {
        InvalidNameException.ThrowIfInvalid(firstname, lastName);
        return new Name(firstname, lastName);
    }

    #endregion
    
}