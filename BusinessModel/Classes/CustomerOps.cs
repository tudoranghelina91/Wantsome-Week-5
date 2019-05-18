﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Interfaces;
using BusinessModel.Classes;

namespace BusinessModel.Classes
{
    public static class CustomerOps
    {
        public static void PrintOrders(IPerson customer, string message)
        {
            Console.WriteLine(message);
            customer.Print();
        }

        public static void PlaceOrder(IPerson customer, IStore store, IVehicle vehicle)
        {
            customer.PlaceOrder(store, vehicle);
        }

        public static void CancelOrder(IPerson customer, IStore store, IVehicle vehicle)
        {
            customer.CancelOrder(store, customer.Orders.Find(o => o.Vehicle.Model == vehicle.Model));
        }
    }
}
