using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.LandVehicles
{
    internal class Motorcycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Iniciamos a encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
