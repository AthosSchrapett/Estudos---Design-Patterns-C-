using Abstract_Factory.Aircrafts;
using Abstract_Factory.Factories;
using Abstract_Factory.LandVehicles;

namespace Abstract_Factory.App
{
    internal class Application
    {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();
        }

        public void StartRout()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
