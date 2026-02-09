namespace DesignPatterns.SOLID.S;

public class UserService
{
    public void Register(User user)
    {
        // Register user logic ...
        
        // Send email notification
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(user.Email, "Welcome to our platform.");
        
    }
}