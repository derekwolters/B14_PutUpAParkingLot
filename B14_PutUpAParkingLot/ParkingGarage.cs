using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14_PutUpAParkingLot
{
    class ParkingGarage
    {
        private Level[] level = new Level[5];

        public Level GetLevel(int index)
        {
            return level[index];
        }
    }
}
