using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1.Vehicles
{
    internal abstract class GroundVehicle: Vehicle
    {
        public abstract int MaxTravelTime { get; set; }
        public abstract int RestDuration { get; set; }
        public abstract int TimeTraveled { get; set; }
    }
}
