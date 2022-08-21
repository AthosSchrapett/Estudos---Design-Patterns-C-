namespace Lsp.Payments
{
    public class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento Realizado com sucesso");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite ok. Rewards ok!");
        }
    }
}
