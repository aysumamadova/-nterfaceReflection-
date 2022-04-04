﻿using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface_Reflection_task.Models
{
    interface IEngine
    {
        public double HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }

        public double LeftFuelAmount();


    }
}
