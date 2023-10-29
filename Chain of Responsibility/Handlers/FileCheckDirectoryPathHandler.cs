namespace DesignPattern.ChainOfResponsibility.Handlers;
public class FileCheckDirectoryPathHandler : Handler
{
    public override void HandleFileProcessing(string path)
    {
        if (Directory.Exists(Directory.GetParent(path).Parent.FullName) && _handler != null)
        {
            System.Console.WriteLine($"The Given {Directory.GetParent(path).Parent.FullName} Directory Exists");
            _handler.HandleFileProcessing(path);
        }
        else
        {
            System.Console.WriteLine($"The Given {Directory.GetParent(path).Parent.FullName} Directory doesn't Exists");
        }
    }
}
