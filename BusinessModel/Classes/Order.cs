using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Interfaces;
using IODS.Handlers;

namespace BusinessModel.Classes
{
    class Order : IOrder
    {
        public int Number { get; set; }
        public IStore Store { get; set; }
        public IPerson Customer { get; set; }
        public IVehicle Vehicle { get; set; }
        public int ETA { get; set; }

        public Order(IPerson customer, IVehicle vehicle, IStore store, int eta)
        {
            Customer = customer;
            Vehicle = vehicle;
            ETA = eta;
            Store = store;
        }

        public void Print()
        {
            OutputHandling.Message($"Store: {Store.Name}");
            OutputHandling.Message($"Order #{Number}");
            OutputHandling.Message($"Customer: {Customer.Name}");
            OutputHandling.Message($"Car Manufacturer: {Vehicle.Manufacturer}");
            OutputHandling.Message($"Car Model: {Vehicle.Model}");
            OutputHandling.Message($"Car Year: {Vehicle.Year}");
        }
    }
}
