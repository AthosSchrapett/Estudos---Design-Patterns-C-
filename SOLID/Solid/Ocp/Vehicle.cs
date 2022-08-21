namespace Ocp
{
    public class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um Carro {Color}, {Year}, {Engine}, {Doors} portas e {Seats} assentos.");
            StartVehicle();
        }

        public void Motorcycle()
        {
            Console.WriteLine($"Criando um Carro {Color}, {Year}, {Engine} cilindradas");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
