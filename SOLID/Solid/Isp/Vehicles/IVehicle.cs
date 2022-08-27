namespace Isp.Vehicles
{
    public interface IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
        void ConfigureMotorcycle(string color, int year, double engine);
        void StartVehicle();
    }
}
