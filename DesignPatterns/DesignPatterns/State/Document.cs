namespace DesignPatterns.DesignPatterns.State;

public class Document
{
    public DocumentState State { get; set; }
    public UserRoles CurrentUserRole { get; set; }

    public void Publish()
    {
        if (State == DocumentState.Draft)
        {
            State = DocumentState.Moderation;
        } 
        else if (State == DocumentState.Moderation)
        {
            if (CurrentUserRole == UserRoles.Admin)
            {
                State = DocumentState.Published;
            }
        }
        else if (State == DocumentState.Published)
        {
            // do nothing
        }
    }
}