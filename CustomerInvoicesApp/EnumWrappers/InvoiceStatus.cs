using CustomerInvoicesApp.Enums;

namespace CustomerInvoicesApp.EnumWrappers
{
    public class InvoiceStatus
    {
        public string GetDisplayText(InvoiceStatusEnum invoiceStatus)
        {
            switch (invoiceStatus)
            {
                case InvoiceStatusEnum.Paid:
                    {
                        return "paid";
                    }
                case InvoiceStatusEnum.Upcoming:
                    {
                        return "upcoming";
                    }
                case InvoiceStatusEnum.Cancelled:
                    {
                        return "cancelled";
                    }
                default:
                    return null;
            }
        }
    }
}
