namespace SingleResponsibility;
using OpenClose;
public class FileInvoiceRepository : IInvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saved the Invoice #{ invoice.InvoiceNo } into a file.");
    }
}

public class DBInvoiceRepository : IInvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saved the Invoice #{ invoice.InvoiceNo } into a DB.");
    }
}

public class JSONInvoiceRepository : IInvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saved the Invoice #{ invoice.InvoiceNo } into a JSON file.");
    }
}