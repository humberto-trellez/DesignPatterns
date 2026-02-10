namespace DesignPatterns.DesignPatterns.State.GoodSolution;

public class DraftState : State
{
    private Document _document;

    public DraftState(Document document)
    {
        _document = document;
    }
    public void Publish()
    {
        _document.State = new ModerationState(_document);

    }
}