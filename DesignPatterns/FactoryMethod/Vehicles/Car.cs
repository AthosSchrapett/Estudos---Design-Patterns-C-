using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    public class Car : IVehicle
    {
        public void GetGargo()
        {
            Console.WriteLine("Pegamos os passageiros!");
        }

        public void StartRoute()
        {
            GetGargo();
            Console.WriteLine("Iniciamos o trajeto.");
        }
    }
}
