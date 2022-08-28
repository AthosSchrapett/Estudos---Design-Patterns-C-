using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Aircrafts
{
    internal class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda foi pega");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Subindo");
        }
    }
}
