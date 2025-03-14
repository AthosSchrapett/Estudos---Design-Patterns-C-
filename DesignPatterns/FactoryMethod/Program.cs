﻿using FactoryMethod.Factories;

Transport transport = null;

if (args.Length > 0 && args[0] == "--uber")
    transport = new CarTransport();
else if (args.Length > 0 && args[0] == "--log")
    transport = new MotorcycleTransport();
else if (args.Length > 0 && args[0] == "--delivery")
    transport = new BikeTransport();
else
    Console.WriteLine("Selecione o tipo de serviço.");

if(transport != null)
    transport.StartTransport();

Console.ReadLine();