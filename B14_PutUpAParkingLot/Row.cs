using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14_PutUpAParkingLot
{
    class Row
    {
        private int rowSize;

        public Row(int r)
        {         
            if (r == 5)
            {
                rowSize = r;
            }
            else
            {
                rowSize = -1;
                Console.WriteLine("Invalid Size Given to row");
            }
        }

        private Space[] space = new Space[5];

        public Space GetSpace(int index)
        {
            return space[index];
        }
    }
}

