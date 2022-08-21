namespace Ocp.Vehicles
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }

        public Vehicle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
