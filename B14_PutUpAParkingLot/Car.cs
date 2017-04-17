using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B14_PutUpAParkingLot
{
    class Car : IVehicle
    {
        private string name;
        private List<int> requiredSpotSize;
        private int numberOfSpots;

        public Car(string name)
        {
            this.name = name;
            this.requiredSpotSize = new List<int> { 2,3 };
            this.numberOfSpots = 1;
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
