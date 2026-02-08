namespace DesignPatterns.OOPPrinciples.Coupling;

public class Order
{
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }
    
    public void PlaceHolder()
    {
        // Place order logic
        notificationService.SendNotification("Order placed successfully.");
    }
    
}