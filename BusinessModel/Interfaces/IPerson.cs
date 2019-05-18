﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        List<IOrder> Orders { get; set; }

        void PlaceOrder(IStore store, IVehicle vehicle);
        void CancelOrder(IStore store, IOrder order);
        void Print();
    }
}
