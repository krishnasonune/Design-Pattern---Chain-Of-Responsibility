namespace DesignPattern.ChainOfResponsibility.Handlers;
public class FileCheckExistsHandler : Handler
{
    public override void HandleFileProcessing(string path)
    {
        if (File.Exists(path) && _handler != null)
        {
            System.Console.WriteLine($"The Given File Exists at {path}");
            _handler.HandleFileProcessing(path);
        }
        else
        {
            System.Console.WriteLine($"The Given File Doesn't Exists at {path}");
        }
    }
}
