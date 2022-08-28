using Abstract_Factory.Aircrafts;
using Abstract_Factory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    internal class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
