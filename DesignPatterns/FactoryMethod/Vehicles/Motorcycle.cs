namespace FactoryMethod.Vehicles
{
    public class Motorcycle : IVehicle
    {
        public void GetGargo()
        {
            Console.WriteLine("Pegamos a encomenda!");
        }

        public void StartRoute()
        {
            GetGargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
