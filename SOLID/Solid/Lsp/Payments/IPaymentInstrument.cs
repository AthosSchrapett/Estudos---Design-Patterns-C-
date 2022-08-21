namespace Lsp.Payments
{
    internal interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
