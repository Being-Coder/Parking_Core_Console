using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_slot
{
    public class Parking
    {
        // Maximum time consumed to decide wheather to use static or instance ????? 

        // public static int TotalSmallSlots { get; }
        // public static int TotalMediumSlots { get; }
        // public static int TotalLargeSlots { get; }

        public int TotalSmallSlots { get; set; }
        public int TotalMediumSlots { get; set; }
        public int TotalLargeSlots { get; set; }
        public int TotalAvailableSlots { get; set; }

        //public int AvailableSmallSlots { get; set; }
        //public int AvailableMediumSlots { get; set; }
        //public int AvailableLargeSlots { get; set; }

        private static Parking ParkingInstance = null;

        private Parking()
        {
            //this.AvailableLargeSlots = 20;
            //this.AvailableMediumSlots = 50;
            //this.AvailableSmallSlots = 100;
            this.TotalAvailableSlots = 100;
            this.TotalSmallSlots = 50;
            this.TotalMediumSlots = 30;
            this.TotalLargeSlots = 20;
        }
        
        public static Parking GetParking
        { 
            get 
            { 
                if (ParkingInstance == null)
                {
                    return ParkingInstance = new Parking();
                }

                return ParkingInstance;
            }
        }

        #region ParkingCalculatedCtor
        //public Parking()
        //{
        //    this.AvailableSmallSlots = Parking.TotalSmallSlots - this.OccupiedSmallSlots;
        //    this.AvailableMediumSlots = Parking.TotalMediumSlots - this.OccupiedMediumSlots;
        //    this.AvailableLargeSlots = Parking.TotalLargeSlots - this.OccupiedLargeSlots;
        //    this.OccupiedSmallSlots = Parking.TotalSmallSlots - this.AvailableSmallSlots;
        //    this.OccupiedMediumSlots = Parking.TotalMediumSlots - this.AvailableMediumSlots;
        //    this.OccupiedLargeSlots = Parking.TotalLargeSlots - this.AvailableLargeSlots;
        //}
        #endregion

    }
}
