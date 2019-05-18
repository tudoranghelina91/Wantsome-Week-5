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
            IPerson person = new Customer("Alex");

            person.PlaceOrder(StoresStruct.FordStore, CarsStruct.FordFocus);

            Console.WriteLine("Orders after ordering from Ford Store");
            person.Print();

            person.PlaceOrder(StoresStruct.SkodaStore, CarsStruct.FordFocus);

            Console.WriteLine("Orders after ordering new model from Skoda Store");
            person.Print();

            person.CancelOrder(StoresStruct.FordStore, person.Orders.Find(o => o.Vehicle.Model == CarsStruct.FordFocus.Model));

            Console.WriteLine("Orders after cancelling the order on Ford Store");
            person.Print();
            Console.ReadKey();
        }
    }
}
