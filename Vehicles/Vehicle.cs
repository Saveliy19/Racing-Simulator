﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal abstract class Vehicle : IMovable
    {
        public abstract int Speed { get; set; }

        public abstract double DistanceTraveled { get; }
        public abstract void Move();
    }
}
