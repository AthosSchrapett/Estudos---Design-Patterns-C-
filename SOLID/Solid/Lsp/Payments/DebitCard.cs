using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    public class DebitCard : NubankCard
    {

        public override void Validate()
        {
            Console.WriteLine("Verifica Saldo");
            Console.WriteLine("Saldo disponivel!");
        }

    }
}
