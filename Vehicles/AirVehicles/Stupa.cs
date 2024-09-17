using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.AirVehicles
{
    internal class Stupa: AirVehicle 
    {
        int accelerationCoefficient = 0;
        int speed = 1; 
        protected override int AccelerationCoefficient
        {
            get
            {
                return accelerationCoefficient;
            }

            set
            {
                accelerationCoefficient = value;
            }
        }

        public override int DistanceTraveled 
        {
            get { return distanceTraveled;  }
        }

        public override void Move()
        {
            distanceTraveled = speed * timeTraveled + (accelerationCoefficient * timeTraveled * timeTraveled) / 2;
            Console.WriteLine($"Дистанция ступы - {distanceTraveled.ToString()} Время ступы {timeTraveled.ToString()}");
            Console.WriteLine();
            accelerationCoefficient = distanceTraveled;
            timeTraveled++;

        }

        protected override int Speed { get; set; }

    }
}
