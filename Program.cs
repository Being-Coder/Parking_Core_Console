using System;

namespace Parking_slot
{
    class Program
    {
        public enum CarTypes
        {
            Closed,
            Hatchback,
            Sedan,
            SUV,
        }
        public static void Main(string[] args)
        {
            ParkingFactory parkingFactory = new ParkingFactory();
            Cars cars = null;
            CarTypes CurrentCar = CarTypes.Hatchback;
            while ((CurrentCar = EnteredCar()) != CarTypes.Closed)
            {
                cars = parkingFactory.CurrentCarObject(CurrentCar);
                cars.welcome();
            }
        }

        public static CarTypes EnteredCar()
        {
            int CarType = 0;

            Console.WriteLine("");
            Console.WriteLine("Hello welcome to car parking : ");
            Console.WriteLine("");
            Console.WriteLine("Choose the type of car : ");
            Console.WriteLine("0 : Parking Closed ");
            Console.WriteLine("1 : Hatchback / Small ");
            Console.WriteLine("2 : Sedan / Compact SUV ");
            Console.WriteLine("3 : SUV / Large Cars ");
            bool IsValidType = int.TryParse(Console.ReadLine(), out CarType);

            if(IsValidType && CarType < 4)
            return (CarTypes)CarType;

            Console.WriteLine("Please select valid option");
            EnteredCar();
            return CarTypes.Hatchback;
        }
    }
}
