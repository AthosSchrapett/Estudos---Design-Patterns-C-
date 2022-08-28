using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.LandVehicles
{
    internal class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Encomenda foi pega, pronto para entregar");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Inciando trajeto");
        }
    }
}
