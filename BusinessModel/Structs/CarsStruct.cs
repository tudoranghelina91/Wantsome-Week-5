using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Classes;
using BusinessModel.Interfaces;

namespace BusinessModel.Structs
{
    struct CarsStruct
    {
        public static IVehicle FordFocus = new Car("Ford", "Focus", 2015);
    }
}
