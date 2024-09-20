namespace InterfaceSegregation;
public interface IFlyable
{
    void Fly();
}
public interface IRunnable
{
    void Run();
}
public class Aircraft : IRunnable, IFlyable
{
    public void Run() => Console.WriteLine("Running...");
    public void Fly() => Console.WriteLine("Flying...");
}
public class Car : IRunnable
{
    public void Run() => Console.WriteLine("Running...");
}