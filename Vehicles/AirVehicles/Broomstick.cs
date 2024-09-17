﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.AirVehicles
{
    internal class Broomstick: AirVehicle
    {
        int accelerationCoefficient = 0;
        int speed = 1;
        public override int DistanceTraveled
        {
            get { return distanceTraveled; }
        }

        public override void Move()
        {
            distanceTraveled = speed * timeTraveled + (accelerationCoefficient * timeTraveled * timeTraveled) / 2;
            timeTraveled++;
            accelerationCoefficient = distanceTraveled / 2;
        }

        protected override int AccelerationCoefficient 
        { 
            get { return AccelerationCoefficient; }
            set { AccelerationCoefficient = value; }
        }
        protected override int Speed { get; set; }


    }
}
