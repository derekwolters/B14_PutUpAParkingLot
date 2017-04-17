using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14_PutUpAParkingLot
{
    class Bus : IVehicle
    {
        private string name;
        private List<int> requiredSpotSize;
        private int numberOfSpots;

        public Bus(string name)
        {
            this.name = name;
            this.requiredSpotSize = new List<int> { 3 };
            this.numberOfSpots = 5;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int GetNumberOfSpots
        {
            get { return numberOfSpots; }
        }

        public List<int> GetRequiredSpotSize()
        {
            return requiredSpotSize;
        }
    }
}
