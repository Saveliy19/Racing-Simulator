using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles.GroundVehicles
{
    internal class BootsRunners: GroundVehicle
    {
        private int maxTravelTime = 5;
        private int restDuration = 1;
        private int speed = 1;
        private int distanceTraveled = 0;
        private int timeTraveled = 0;

        public override double DistanceTraveled
        {
            get { return distanceTraveled; }
        }

        public override int TimeTraveled
        {
            get { return timeTraveled; }
            set { timeTraveled = value; }
        }
        public override void Move()
        {
            if (timeTraveled < maxTravelTime)
            {
                distanceTraveled += speed;
            }
            else if (timeTraveled >= maxTravelTime + restDuration)
            {
                timeTraveled = 0;
            }
            timeTraveled++;
            Console.WriteLine($"Дистанция - {distanceTraveled.ToString()} Время{timeTraveled.ToString()}");
            Console.WriteLine();

        }
        public override int Speed 
        {
            get { return speed; }
            set { speed = value; }
        }
        public override int MaxTravelTime 
        { 
            set { maxTravelTime = value;  }
            get { return maxTravelTime; }
        }

        public override int RestDuration
        {
            set { restDuration = value; }
            get { return restDuration; }
        }

    }
}
