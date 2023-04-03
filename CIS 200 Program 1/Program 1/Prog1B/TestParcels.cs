using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        static void Main(string[] args)
        {

            bool VERBOSE = false;

            
            Address a1 = new Address("John Marston", "2525 Martin St.", "Apt. 45", "Louisville", "KY", 40208);
            Address a2 = new Address("Geno Smith", "365 Monday St.", "Orange City", "CA", 25424); 
            Address a3 = new Address("Christian Walker", "588 Newpalace Place", "Room 45","Katy", "TX", 36582); 
            Address a4 = new Address("Will Tonder", "777 Nerd Lane", "Apt. 87", "Portland", "OR", 14578); 
            Address a5 = new Address("Trey Hernandez", "111 Market St.", "Jeffersonville", "IN", 47130); 
            Address a6 = new Address("Key Peele", "59 Hollywood Blvd.", "Apt. 47", "Los Angeles", "CA", 14735); 
            Address a7 = new Address("Darth Vader", "225 Empire Lane", "Apt 434","Saber", "FL", 89321);
            Address a8 = new Address("Justin Jacobs", "566 Ferrylane St", "Apt. 5", "Tampa", "FL", 40175); 

            Letter letter1 = new Letter(a1, a2, 3.95M);                            
            Letter letter2 = new Letter(a3, a4, 4.25M);                           
            GroundPackage gp1 = new GroundPackage(a5, a6, 14, 10, 5, 12.5);        
            GroundPackage gp2 = new GroundPackage(a7, a8, 8.5, 9.5, 6.5, 2.5);    
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15, 85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a5, 9.5, 6.0, 5.5, 5.25, 5.25M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 10.5, 6.5, 9.5, 15.5, 5.00M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a5, a7, 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a1, 15.0, 9.5, 6.5, 75.5, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a4, 12.0, 12.0, 6.0, 5.5, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;     

            parcels = new List<Parcel>();

            parcels.Add(letter1); 
            parcels.Add(letter2);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            var parcelsByDestZip =
                from p in parcels
                orderby p.DestinationAddress.Zip descending
                select p;

            WriteLine("Parcels by Destination Zip (desc):");
            WriteLine("====================");

            foreach (Parcel p in parcelsByDestZip)
            {
                if (VERBOSE)
                {
                    WriteLine(p);
                    WriteLine("====================");
                }
                else
                    WriteLine($"{p.DestinationAddress.Zip:D5}");
            }
            Pause();

            var parcelsByCost =
                from p in parcels
                orderby p.CalcCost()
                select p;

            WriteLine("Parcels by Cost:");
            WriteLine("====================");
            foreach (Parcel p in parcelsByCost)
            {
                if (VERBOSE)
                {
                    WriteLine(p);
                    WriteLine("====================");
                }
                else
                    WriteLine($"{p.CalcCost(),8:C}");
            }
            Pause();

            var parcelsByTypeCost =
                from p in parcels
                orderby p.GetType().ToString(), p.CalcCost() descending
                select p;

            WriteLine("Parcels by Type and Cost (desc):");
            WriteLine("====================");
            foreach (Parcel p in parcelsByTypeCost)
            {
                if (VERBOSE)
                {
                    WriteLine(p);
                    WriteLine("====================");
                }
                else
                    WriteLine($"{p.GetType().ToString(),-17} {p.CalcCost(),8:C}");
            }
            Pause();

            var heavyAirPackagesByWeight =
                from p in parcels
                let ap = p as AirPackage 
                where (ap != null) && ap.IsHeavy() 
                orderby ap.Weight descending
                select ap;

            WriteLine("Heavy AirPackages by Weight (desc):");
            WriteLine("====================");
            foreach (AirPackage ap in heavyAirPackagesByWeight)
            {
                if (VERBOSE)
                {
                    WriteLine(ap);
                    WriteLine("====================");
                }
                else
                    WriteLine("{0,-17} {1,4:F1}", ap.GetType().ToString(),
                        ap.Weight);
            }
        }

    public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Clear(); 
        }
    }
}
