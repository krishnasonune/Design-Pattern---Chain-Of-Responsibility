using System;
using DesignPattern.ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating objects of all Handlers
            var fileCheckDirectoryPathHandler = new FileCheckDirectoryPathHandler();
            var fileCheckExistsHandler = new FileCheckExistsHandler();
            var fileContentHandler = new FileContentHandler();
            var fileDataReadHandler = new FileDataReadHandler();

            //Chaining up the handlers for processing
            fileCheckDirectoryPathHandler.nextHandler(fileCheckExistsHandler);
            fileCheckExistsHandler.nextHandler(fileContentHandler);
            fileContentHandler.nextHandler(fileDataReadHandler);
            fileDataReadHandler.nextHandler(default);

            string path = @"/home/Users/Documents/sample.txt";
            fileCheckDirectoryPathHandler.HandleFileProcessing(path);

        }
    }
}
