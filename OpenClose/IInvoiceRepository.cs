namespace OpenClosed;
using SingleResponsibility;
interface IInvoiceRepository
{
    void Save (Invoice invoice);
}