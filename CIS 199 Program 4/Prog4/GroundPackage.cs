// Program 4
// CIS 199-XX
// Due: 4/20/2020
// Jacob Puentes

// This file models the business logic for GroundPackages.
// Each has origin and destination zip codes, length,
// width, height, and weight.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class GroundPackage
    {
        // Backing fields
        private int _originZip;
        private int _destZip;   
        private double _length; 
        private double _width; 
        private double _height; 
        private double _weight;

        // Validation values
        public const int MIN_ZIP = 00000;
        public const int MAX_ZIP = 99999; 

        // Defaults to be used when constructor receives invalid data
        public const int DEFAULT_ORIGIN_ZIP = 40204;  
        public const int DEFAULT_DEST_ZIP = 60606;    
        public const double DEFAULT_DIM = 12.0;       

        
        public GroundPackage(int oZip, int dZip, double pLength,
            double pWidth, double pHeight, double pWeight)
        {
           
            OriginZip = oZip;
            DestinationZip = dZip;
            Length = pLength;
            Width = pWidth;
            Height = pHeight;
            Weight = pWeight;
        }

        public int OriginZip
        {
           
            get
            {
                return _originZip;
            }

                       specified value
            set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))
                    _originZip = value;
                else
                    _originZip = DEFAULT_ORIGIN_ZIP;
            }
        }

        public int DestinationZip
        {
            
            get
            {
                return _destZip;
            }

                         specified value
            set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))
                    _destZip = value;
                else
                    _destZip = DEFAULT_DEST_ZIP;
            }
        }

        public double Length
        {
            
            get
            {
                return _length;
            }

                       specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = DEFAULT_DIM;
            }
        }

        public double Width
        {
            
            get
            {
                return _width;
            }

            
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = DEFAULT_DIM;
            }
        }

        public double Height
        {
            
            get
            {
                return _height;
            }

           
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = DEFAULT_DIM;
            }
        }

        public double Weight
        {
            
            get
            {
                return _weight;
            }

                   specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = DEFAULT_DIM;
            }
        }

        public int ZoneDistance
        {
            
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; 
                int diff;                           

                diff = (OriginZip / FIRST_DIGIT_FACTOR) - (DestinationZip / FIRST_DIGIT_FACTOR);

                return Math.Abs(diff); 
            }
        }

        
        public double CalcCost()
        {
            const double SIZE_COST_FACTOR = .20;  
            const double WEIGHT_COST_FACTOR = .35; 

            return (SIZE_COST_FACTOR * (Length + Width + Height) + WEIGHT_COST_FACTOR * (ZoneDistance + 1) * Weight);
        }

        
        public override string ToString()
        {
            string NL = Environment.NewLine; 

            return $"Origin: {OriginZip:D5}{NL}" +
                $"Destination: {DestinationZip:D5}{NL}" +
                $"Length: {Length:N1}{NL}" +
                $"Width: {Width:N1}{NL}" +
                $"Height: {Height:N1}{NL}" +
                $"Weight: {Weight:N1}";
        }
    }
}
