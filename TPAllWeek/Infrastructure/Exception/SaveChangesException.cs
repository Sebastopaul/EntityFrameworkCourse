namespace TPAllWeek.Infrastructure.Exception;

public class SaveChangesException : System.Exception
{
    public SaveChangesException() : base("An error occured while attempting to save changes.") { }
    public SaveChangesException(string message) : base(message) { }
    public SaveChangesException(string message, System.Exception exception) : base(message, exception) { }
}