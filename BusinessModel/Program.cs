using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Interfaces;
using BusinessModel.Classes;

namespace BusinessModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle FordFocus = new Car("Ford", "Focus", 2015);

            IStore FordStore = new Store("Ford Store", 4, 
                new List<IVehicle>() {
                    new Car("Ford", "Focus", 2015, 15000),
                });

            IStore SkodaStore = new Store("Skoda Store", 3,
                new List<IVehicle>() {
                    new Car("Ford", "Focus", 2015, 14000),
                });

            IPerson person = new Customer("Alex");
            person.PlaceOrder(FordStore, FordFocus);
            Console.WriteLine("Orders after ordering from Ford Store");
            person.Print();
            person.PlaceOrder(SkodaStore, FordFocus);
            Console.WriteLine("Orders after ordering new model from Skoda Store");
            person.Print();
            person.CancelOrder(FordStore, person.Orders.Find(o => o.Vehicle.Model == FordFocus.Model));
            Console.WriteLine("Orders after cancelling the order on Ford Store");
            person.Print();
            Console.ReadKey();
        }
    }
}
