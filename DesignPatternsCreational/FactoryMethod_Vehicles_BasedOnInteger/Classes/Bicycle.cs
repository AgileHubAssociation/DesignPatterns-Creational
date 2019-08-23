﻿using System;

namespace FactoryMethod_Vehicles_BasedOnInteger.Classes
{
    internal class Bicycle : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Acelerate from Bicycle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop from Bicycle");
        }
    }
}