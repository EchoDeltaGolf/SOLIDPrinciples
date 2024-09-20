using System.Security.Cryptography.X509Certificates;
namespace DependencyInversion;
public interface IDataService
{
    public void Save(string message);
}
public class DatabaseService : IDataService
{
    public void Save(string message)
    {
        Console.WriteLine("Save the message to the database.");
    }
}

public class Logger
{
    private readonly IDataService _databaseService;

    public Logger(IDataService databaseService)
    {
        _databaseService = databaseService;
    }
    public void Log(string message)
    {
        _databaseService.Save(message);
    }
}