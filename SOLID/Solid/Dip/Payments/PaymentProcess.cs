using Dip.Factory;
using Dip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Payments
{
    public class PaymentProcess
    {
        public void Pay(string id)
        {
            IDbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
