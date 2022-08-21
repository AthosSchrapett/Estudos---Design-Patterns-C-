using Ocp;

TypeVehicle type = TypeVehicle.Motorcycle;

if (type == TypeVehicle.Car)
{
    Vehicle vehicle = new("Azul", 2022, 2.0, 5, 4);
    vehicle.Car();
}
else
{
    Vehicle vehicle = new("Branco", 2023, 250, 1, 0);
    vehicle.Motorcycle();
}

Console.ReadLine();
