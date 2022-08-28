using Builder.Builders;
using Builder.Directors;
using Builder.Products;

VehicleBuilder builder = new VehicleBuilder();
Director director = new Director(builder);

director.ContructSedanCar();

Vehicle sedan = builder.GetVehicle();

Console.WriteLine($"Criando um veículo do tipo: {sedan.VehicleType}");

director.ContructTruck();

Vehicle truck = builder.GetVehicle();

Console.WriteLine($"Criando um veículo do tipo: {truck.VehicleType}");

director.ContructSuv();

Vehicle suv = builder.GetVehicle();

Console.WriteLine($"Criando um veículo do tipo: {suv.VehicleType} com {suv.Accessories}");

Console.ReadLine();