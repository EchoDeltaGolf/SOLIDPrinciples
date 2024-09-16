namespace SOLIDPrinciples;

using LiskovSubstitution;
using OpenClose;
using SingleResponsibility;

class Program
{
    public static void TestDrive(Vehicle vehicle)
    {
        vehicle.Drive();
    }

    static void Main(string[] args)
    {
        #region Liskov Substitution Principle
        var car = new Car();
        TestDrive(car);

        var truck = new Truck();
        TestDrive(truck);

        var aircraft = new Aircraft();
        TestDrive(aircraft); // side effect
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

        // var fileInvoiceRepo = new FileInvoiceRepository();
        // fileInvoiceRepo.Save(invoice);

        Console.WriteLine("Hello, World!");
    }
}
