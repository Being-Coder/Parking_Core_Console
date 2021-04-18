using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_slot
{
    public abstract class Cars
    {
        public abstract void welcome();
        
    }

    public class Hatchback : Cars
    {
        public override void welcome()
        {

            // If I Used all as static veriable then what is benifit or what is loss ???? 
            // Console.WriteLine(Parking.AvailableSmallSlots--);

            Parking parking = Parking.GetParking;

            if(parking.TotalAvailableSlots > 0 && parking.TotalSmallSlots > 0)
            {
                Console.WriteLine("Welcome Hatchback : ");
                Console.WriteLine("");

                parking.TotalAvailableSlots--;
                parking.TotalSmallSlots--;

                Console.WriteLine("Parking available for {0} Hatchbacks.", parking.TotalAvailableSlots);
                Console.WriteLine("Parking available for {0} Sedan.", parking.TotalLargeSlots + parking.TotalMediumSlots);
                Console.WriteLine("Parking available for {0} SUV's.", parking.TotalLargeSlots);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Parking is full..");
                Console.WriteLine("");
            }
        }
    }

    public class Sedan : Cars
    {
        public override void welcome()
        {
            Parking parking = Parking.GetParking;

            if(parking.TotalAvailableSlots > 0 && parking.TotalMediumSlots > 0)
            {
                Console.WriteLine("Welcome Sedan : ");
                Console.WriteLine("");

                parking.TotalAvailableSlots--;
                parking.TotalMediumSlots--;

                Console.WriteLine("Parking available for {0} Hatchbacks.", parking.TotalAvailableSlots);
                Console.WriteLine("Parking available for {0} Sedan.", parking.TotalLargeSlots + parking.TotalMediumSlots);
                Console.WriteLine("Parking available for {0} SUV's.", parking.TotalLargeSlots);
                Console.WriteLine("");
                //Hatchback hatchback = new Hatchback();
                //hatchback.welcome();
            }
            else
            {
                Console.WriteLine("No parking available for Sedan's & SUV's.");
                Console.WriteLine("");
            }
        }
    }

    public class SUV : Cars 
    {
        public override void welcome()
        {
            Parking parking = Parking.GetParking;

            if(parking.TotalAvailableSlots > 0 && parking.TotalLargeSlots > 0)
            {
                Console.WriteLine("Welcome SUV : ");
                Console.WriteLine("");

                parking.TotalAvailableSlots--;
                parking.TotalLargeSlots--;
                Console.WriteLine("Parking available for {0} Hatchbacks.", parking.TotalAvailableSlots);
                Console.WriteLine("Parking available for {0} Sedan.", parking.TotalLargeSlots + parking.TotalMediumSlots);
                Console.WriteLine("Parking available for {0} SUV's.", parking.TotalLargeSlots);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No parking available for SUV's.");
                Console.WriteLine("");
            }
        }
    }
}
