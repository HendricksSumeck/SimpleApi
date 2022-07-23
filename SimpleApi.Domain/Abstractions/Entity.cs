namespace SimpleApi.Domain.Abstractions;

public abstract class Entity
{
    protected Entity()
    {
        Id = Guid.NewGuid();
        DeletedIn = null;
        Active = true;
        RegisteredIn = DateTime.UtcNow;
        UpdatedIn = DateTime.UtcNow;
    }

    public Guid Id { get; set;}
    public DateTime? DeletedIn { get; set; }
    public bool Active { get; set; }
    public DateTime RegisteredIn { get; set; }
    public DateTime UpdatedIn { get; set; }
    
    public void Update()
    {
        UpdatedIn = DateTime.UtcNow;
    }
    public void Delete()
    {
        UpdatedIn = DateTime.UtcNow;
        DeletedIn = DateTime.UtcNow;
        Active = false;
    }
}