using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            Console.WriteLine("realizando adaptação do paypal para payonner");
            this.payonner = payonner;
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            AuthToken();
            this.payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            AuthToken();
            this.payonner.ReceivePayment();
        }
    }
}
