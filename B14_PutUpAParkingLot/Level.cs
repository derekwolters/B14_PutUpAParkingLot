using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14_PutUpAParkingLot
{
    class Level
    {
        private Row[] row = new Row[4];
        
        public Row GetRow(int index)
        {
            return row[index];
        }

        public bool GetEmptyRow(Row[] row)
        {
            if (row.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    } 
}
