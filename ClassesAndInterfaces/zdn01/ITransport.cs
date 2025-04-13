using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn01
{
    public interface ITransport
    {
        static string TransportType { get; }
        double RentalCostPerMinute { get; }
    }
}
