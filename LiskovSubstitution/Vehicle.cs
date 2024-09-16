namespace LiskovSubstitution;
public abstract class Vehicle
{
    public abstract void Drive();
}

public class Car : Vehicle
{
    public override void Drive() => Console.WriteLine("Drive a car.");
}

public class Truck : Vehicle
{
    public override void Drive() => Console.WriteLine("Drive a truck.");
}