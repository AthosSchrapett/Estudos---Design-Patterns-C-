using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            Console.WriteLine("realizando adaptação do paypal para Mercado Pago");
            this.mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.SendNewPayment();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.ReceiveNewPayment();
        }
    }
}
