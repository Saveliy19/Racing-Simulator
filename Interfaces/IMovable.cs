﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal interface IMovable
    {
        void Move();
        int DistanceTraveled { get; }
    }
}
