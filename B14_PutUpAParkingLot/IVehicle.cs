using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14_PutUpAParkingLot
{
    interface IVehicle
    {
        string Name { get; set; }
        int GetNumberOfSpots { get; }
        List<int> GetRequiredSpotSize();
    }
}
