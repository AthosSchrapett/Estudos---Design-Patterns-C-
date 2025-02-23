﻿using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    internal class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ContructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ContructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }

        public void ContructSuv()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetAccessories(Accessories.AIR_BAGS);
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
        }
    }
}
