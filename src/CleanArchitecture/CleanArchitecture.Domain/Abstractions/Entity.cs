

namespace CleanArchitecture.Domain.Abstractions;

public abstract class Entity
{

    protected Entity(Guid id)
    {
        Id = id;
    }
    public Guid Id {get; init;} // una vez q cree el objeto va a tener su valor identificador por siempre
}
