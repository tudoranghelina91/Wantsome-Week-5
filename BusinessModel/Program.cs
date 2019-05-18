using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Interfaces;
using BusinessModel.Classes;
using BusinessModel.Structs;

namespace BusinessModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson Alex = CustomersStruct.Alex;
            IVehicle FordFocus = CarsStruct.FordFocus;
            IStore FordStore = StoresStruct.FordStore;
            IStore SkodaStore = StoresStruct.SkodaStore;

            CustomerOps.PlaceOrder(Alex, FordStore, FordFocus);
            CustomerOps.PrintOrders(Alex, "Orders after ordering from Ford Store");
            CustomerOps.PlaceOrder(Alex, SkodaStore, FordFocus);
            CustomerOps.PrintOrders(Alex, "Orders after ordering new model from Skoda Store");
            CustomerOps.CancelOrder(Alex, FordStore, FordFocus);
            CustomerOps.PrintOrders(Alex, "Orders after cancelling the order on Ford Store");
            Console.ReadKey();
        }
    }
}
