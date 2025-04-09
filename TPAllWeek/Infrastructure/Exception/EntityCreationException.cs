namespace TPAllWeek.Infrastructure.Exception;

public class EntityCreationException : System.Exception
{
    public EntityCreationException() : base("Could not create entity.") { }
    public EntityCreationException(string message) : base(message) { }
    public EntityCreationException(string message, System.Exception exception) : base(message, exception) { }
}