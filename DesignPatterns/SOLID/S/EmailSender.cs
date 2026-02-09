namespace DesignPatterns.SOLID.S;

public class EmailSender
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine($"Sending emial to {email}: {message}");
    }
}