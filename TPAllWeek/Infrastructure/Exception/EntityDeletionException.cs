namespace TPAllWeek.Infrastructure.Exception;

public class EntityDeletionException : System.Exception
{
    public EntityDeletionException() : base("Could not delete entity.") { }
    public EntityDeletionException(string message) : base(message) { }
    public EntityDeletionException(string message, System.Exception exception) : base(message, exception) { }
}