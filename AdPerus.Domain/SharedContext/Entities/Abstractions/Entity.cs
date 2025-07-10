using AdPerus.Domain.SharedContext.Events.Abstractions;

namespace AdPerus.Domain.SharedContext.Entities.Abstractions;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.CreateVersion7();

    private readonly List<IDomainEvent> _domainEvents = [];
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents;
    public void AddDomainEvent(IDomainEvent @domainEvent) => _domainEvents.Add(@domainEvent);
    public void ClearDomainEvents() => _domainEvents.Clear();
    public DateTime CreatedAt  { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}