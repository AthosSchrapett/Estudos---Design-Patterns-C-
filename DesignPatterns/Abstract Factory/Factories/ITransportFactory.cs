using Abstract_Factory.Aircrafts;
using Abstract_Factory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    internal interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandVehicle CreateTransportVehicle();
    }
}
