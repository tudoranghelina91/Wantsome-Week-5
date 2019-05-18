using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Interfaces;

namespace BusinessModel.Classes
{
    public abstract class Producer : IProducer
    {
        public string Manufacturer { get; set; }
    }
}
