namespace SimpleApi.Domain.Abstractions;

public class Entity
{
    private DateTime? _registeredIn;
    private DateTime? _updatedIn;
    
    public Guid Id { get; set; }
    public DateTime? DeletedIn { get; set; }
    public bool Active { get; set; }
    public DateTime RegisteredIn { get => _registeredIn ??= DateTime.UtcNow; set => _registeredIn = value; }
    public DateTime UpdatedIn { get => _updatedIn ??= DateTime.UtcNow; set => _updatedIn = value; }
}