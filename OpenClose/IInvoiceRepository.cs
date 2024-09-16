namespace OpenClose;
using SingleResponsibility;
interface IInvoiceRepository
{
    void Save (Invoice invoice);
}