namespace Isp.Vehicles
{
    internal class Car : IVehicle, IVehicleCar
    {
        private string Color;
        private int Year;
        private double Engine;
        private int Seats;
        private int Doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;

            Console.WriteLine($"Criando um carro ano {year}, motor {engine} da cor {color}");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
