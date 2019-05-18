using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Interfaces
{
    public interface IOrder
    {
        int Number { get; set; }
        IPerson Customer { get; set; }
        IVehicle Vehicle { get; set; }
        IStore Store { get; set; }
        int ETA { get; set; }

        void Print();
    }
}
