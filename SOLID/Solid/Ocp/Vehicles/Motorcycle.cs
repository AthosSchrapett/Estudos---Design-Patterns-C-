namespace Ocp.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma Moto {Color}, {Year}, {Engine} cilindradas");
            StartVehicle();
        }
    }
}
