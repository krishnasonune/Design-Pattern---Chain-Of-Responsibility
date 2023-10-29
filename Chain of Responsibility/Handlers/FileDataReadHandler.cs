namespace DesignPattern.ChainOfResponsibility.Handlers;
public class FileDataReadHandler : Handler
{
    public override void HandleFileProcessing(string path)
    {
        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            if (_handler != null)
            {
                System.Console.WriteLine("Sending File for further processing");
                _handler.HandleFileProcessing(path);
            }
            else
            {
                var reader = new StreamReader(fs);
                System.Console.WriteLine(reader.ReadToEnd());
                reader.Close();
                reader.Dispose();
            }
            fs.Close();
        }
    }
}
