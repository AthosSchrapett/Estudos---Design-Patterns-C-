namespace Isp.Vehicles
{
    internal class Motorcycle : IVehicle
    {
        private string Color;
        private int Year;
        private double Engine;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            Console.WriteLine($"Criando uma moto ano {year}, {engine} cilindradas, da cor {color}");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
