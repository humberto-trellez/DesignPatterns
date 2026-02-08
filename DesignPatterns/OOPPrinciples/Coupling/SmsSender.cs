namespace DesignPatterns.OOPPrinciples.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("SMS message: " + message);
    }
}