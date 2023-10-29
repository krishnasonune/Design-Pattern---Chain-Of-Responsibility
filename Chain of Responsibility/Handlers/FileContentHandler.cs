namespace DesignPattern.ChainOfResponsibility.Handlers;
public class FileContentHandler : Handler
{
    public override void HandleFileProcessing(string path)
    {
        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            if (fs.Length > 0 && _handler != null)
            {
                System.Console.WriteLine($"Content in given {path} is proper");
                _handler.HandleFileProcessing(path);
            }
            else
            {
                System.Console.WriteLine($"Given {path} is Empty");
            }

            fs.Close();
        }
    }
}
