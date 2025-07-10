namespace AdPerus.Domain.SharedContext.Exceptions.Abstractions;

public abstract class DomainException(string message) : Exception(message);