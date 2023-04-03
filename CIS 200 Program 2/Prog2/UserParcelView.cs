using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVApp
{
    public class UserParcelView
    {
        
        internal List<Address> addresses; 
        internal List<Parcel> parcels;    

      

        public UserParcelView()
        {
            addresses = new List<Address>();
            parcels = new List<Parcel>();
        }

        
        public void AddAddress(String name, String address1, String address2,
        String city, String state, int zipcode)
        {
            Address a; 

            a = new Address(name, address1, address2, city, state, zipcode);
            addresses.Add(a);
        }

       
        public void AddAddress(String name, String address1, String city,
        String state, int zipcode)
        {
            AddAddress(name, address1, string.Empty, city, state, zipcode);
        }

       
        public void AddLetter(Address originAddress, Address destAddress, decimal cost)
        {
            Letter l; 

            l = new Letter(originAddress, destAddress, cost);
            parcels.Add(l);
        }

        
        public void AddGroundPackage(Address originAddress, Address destAddress,
            double pLength, double pWidth, double pHeight, double pWeight)
        {
            GroundPackage p; 

            p = new GroundPackage(originAddress, destAddress, pLength, pWidth,
                pHeight, pWeight);
            parcels.Add(p);
        }

        
        public void AddNextDayAirPackage(Address originAddress, Address destAddress,
            double pLength, double pWidth, double pHeight, double pWeight, decimal expFee)
        {
            NextDayAirPackage p; 

            p = new NextDayAirPackage(originAddress, destAddress, pLength, pWidth,
                pHeight, pWeight, expFee);
            parcels.Add(p);
        }

        
        public void AddTwoDayAirPackage(Address originAddress, Address destAddress,
            double pLength, double pWidth, double pHeight, double pWeight,
            TwoDayAirPackage.Delivery delType)
        {
            TwoDayAirPackage p; 

            p = new TwoDayAirPackage(originAddress, destAddress, pLength, pWidth,
                pHeight, pWeight, delType);
            parcels.Add(p);
        }

        public int AddressCount
        {
           
            get
            {
                return addresses.Count;
            }
        }

        public int ParcelCount
        {
            
            get
            {
                return parcels.Count;
            }
        }

        
        public Address AddressAt(int index)
        {
            if ((index < 0) || (index >= AddressCount))
                throw new ArgumentOutOfRangeException("index", index, "Invalid index!");

            return AddressList[index];
        }

        
        public Parcel ParcelAt(int index)
        {
            if ((index < 0) || (index >= ParcelCount))
                throw new ArgumentOutOfRangeException("index", index, "Invalid index!");

            return ParcelList[index];
        }

        internal List<Address> AddressList
        {
           
            get
            {
                return addresses;
            }
        }

        internal List<Parcel> ParcelList
        {
            
            get
            {
                return parcels;
            }
        }

       
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(); 
            string NL = Environment.NewLine;           
            decimal totalCost = 0;                      

            foreach (Parcel p in ParcelList)
                totalCost += p.CalcCost();

            result.Append($"UserParcelView Info:{NL}");
            result.Append($"Number of Addresses stored: {AddressCount}{NL}");
            result.Append($"Number of Parcels stored:   {ParcelCount}{NL}");
            result.Append($"Total cost of Parcels:      {totalCost:C}{NL}");

            return result.ToString();
        }
    }
}
