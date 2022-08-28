using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MercadoPago : IMercadoPago
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceiveNewPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Mercado Pago");
        }

        public void SendNewPayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com Mercado Pago");
        }
    }
}
