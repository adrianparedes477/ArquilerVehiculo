

namespace CleanArchitecture.Domain.Abstractions;

public abstract class Entity
{

    private readonly List<IDomainEvent> _domainEvents = new();

    protected Entity(Guid id)
    {
        Id = id;
    }
    public Guid Id {get; init;} // una vez q cree el objeto va a tener su valor identificador por siempre

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvents)
    {
        _domainEvents.Add(domainEvents);
    }
}
