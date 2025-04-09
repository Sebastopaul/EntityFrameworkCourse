namespace TPAllWeek.Infrastructure.Exception;

public class EntityNotFoundException : System.Exception
{
    public EntityNotFoundException() : base("Could not retrieve queried entity.") { }
    public EntityNotFoundException(string message) : base(message) { }
    public EntityNotFoundException(string message, System.Exception exception) : base(message, exception) { }
}