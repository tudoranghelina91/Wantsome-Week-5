using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Classes;
using BusinessModel.Interfaces;

namespace BusinessModel.Structs
{
    struct StoresStruct
    {
        public static IStore FordStore = new Store("Ford Store", 4,
            new List<IVehicle>() {
                    new Car("Ford", "Focus", 2015, 15000),
            });

        public static IStore SkodaStore = new Store("Skoda Store", 3,
            new List<IVehicle>() {
                    new Car("Ford", "Focus", 2015, 14000),
            });
    }
}
