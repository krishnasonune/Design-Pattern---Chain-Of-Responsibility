namespace DesignPattern.ChainOfResponsibility.Handlers;
public abstract class Handler
{
    protected Handler _handler;
    public abstract void HandleFileProcessing(string path);

    public void nextHandler(Handler handler)
    {
        this._handler = handler;
    }
}
