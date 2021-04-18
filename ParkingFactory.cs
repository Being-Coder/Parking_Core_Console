using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parking_slot.Program;

namespace Parking_slot
{
    class ParkingFactory
    {
        public Cars CurrentCarObject(CarTypes carTypes)
        {
            Cars cars = null;

            switch(carTypes)
            {
                case CarTypes.Hatchback:
                    return cars = new Hatchback();
               
                case CarTypes.Sedan:
                    return cars = new Sedan();
                 
                case CarTypes.SUV:
                   return cars = new SUV();
                   
            }

            return cars;
        }
    }
}
