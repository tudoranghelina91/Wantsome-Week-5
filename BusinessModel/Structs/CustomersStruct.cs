using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Classes;
using BusinessModel.Interfaces;

namespace BusinessModel.Structs
{
    struct CustomersStruct
    {
        public static IPerson Alex = new Customer("Alex");
    }
}
