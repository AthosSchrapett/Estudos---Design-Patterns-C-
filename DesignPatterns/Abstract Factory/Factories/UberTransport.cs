using Abstract_Factory.Aircrafts;
using Abstract_Factory.LandVehicles;

namespace Abstract_Factory.Factories
{
    internal class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
