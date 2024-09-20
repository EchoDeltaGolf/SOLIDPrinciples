namespace SOLIDPrinciples;
using InterfaceSegregation;
using LiskovSubstitution;
using OpenClosed;
using SingleResponsibility;

class Program
{
    #region Liskov Substitution Principle
    // public static void TestDrive(Vehicle vehicle)
    // {
    //     vehicle.Drive();
    // }
    #endregion
    static void Main(string[] args)
    {
        #region Interface Segregation Principle
        // var aircraft = new InterfaceSegregation.Aircraft();
        // aircraft.Run();
        // aircraft.Fly();

        // var car = new InterfaceSegregation.Car();
        // car.Run();
        #endregion
        #region Liskov Substitution Principle
        // var car = new Car();
        // TestDrive(car);

        // var truck = new Truck();
        // TestDrive(truck);

        // var aircraft = new Aircraft();
        // TestDrive(aircraft); // side effect
        #endregion
        #region Single Responsibility and Open Close Principles
        // var invoice = new Invoice {
        //     InvoiceNo = 1,
        //     Customer = "John Doe",
        //     IssuedDate = new DateOnly(2024, 9, 9),
        //     Description = "Webside Design",
        //     Amount = 1000
        // };

        // IInvoiceRepository repo = new FileInvoiceRepository();
        // repo.Save(invoice);

        // repo = new DBInvoiceRepository();
        // repo.Save(invoice);

        // repo = new JSONInvoiceRepository();
        // repo.Save(invoice);
        #endregion
        #region Open Closed Principle
        // var fileInvoiceRepo = new FileInvoiceRepository();
        // fileInvoiceRepo.Save(invoice);
        #endregion
        Console.WriteLine("Hello, World!");
    }
}
