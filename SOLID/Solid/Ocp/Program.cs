using Ocp;
using Ocp.Vehicles;

TypeVehicle type = TypeVehicle.Car;

if (type == TypeVehicle.Car)
{
    Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);
}
else
{
    Motorcycle vehicle = new Motorcycle("Branco", 2023, 250);
}

Console.ReadLine();
