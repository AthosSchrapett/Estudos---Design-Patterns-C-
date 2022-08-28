using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class Bike : IVehicle
    {
        public void GetGargo()
        {
            Console.WriteLine("Pegamos a marmita!");
        }

        public void StartRoute()
        {
            GetGargo();
            Console.WriteLine("Iniciando o delivery");
        }
    }
}
