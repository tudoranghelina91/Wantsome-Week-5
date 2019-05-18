using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Interfaces
{
    public interface IVehicle : IProducer
    {
        string Model { get; set; }
        int Year { get; set; }
        float Price { get; set; }
    }
}
