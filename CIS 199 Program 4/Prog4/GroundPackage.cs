// Program 4
// CIS 199-XX
// Due: 4/20/2020
// By: Andrew L. Wright (Students use Grading ID)

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
        private int _originZip; // Package's origin zip code
        private int _destZip;   // Package's destination zip code
        private double _length; // Package's length
        private double _width;  // Package's width
        private double _height; // Package's height
        private double _weight; // Package's weight

        // Validation values
        public const int MIN_ZIP = 00000; // Minimum zip code value
        public const int MAX_ZIP = 99999; // Maximum zip code value

        // Defaults to be used when constructor receives invalid data
        public const int DEFAULT_ORIGIN_ZIP = 40204;  // Default zip code
        public const int DEFAULT_DEST_ZIP = 60606;    // Default destinatn
        public const double DEFAULT_DIM = 12.0;       // Default dimension value

        // Precondition:  MIN_ZIP <= oZip <= MAX_ZIP,
        //                MIN_ZIP <= dZip <= MAX_ZIP,
        //                pLength > 0, pWidth > 0,
        //                pHeight > 0, pWeight > 0
        // Postcondition: The ground package is created with the specified values for
        //                origin zip, destination zip, length, width,
        //                height, and weight
        public GroundPackage(int oZip, int dZip, double pLength,
            double pWidth, double pHeight, double pWeight)
        {
            // Use properties to ensure validation occurs
            OriginZip = oZip;
            DestinationZip = dZip;
            Length = pLength;
            Width = pWidth;
            Height = pHeight;
            Weight = pWeight;
        }

        public int OriginZip
        {
            // Precondition:  None
            // Postcondition: The package's origin zip code has been returned
            get
            {
                return _originZip;
            }

            // Precondition:  MIN_ZIP <= value <= MAX_ZIP
            // Postcondition: The package's origin zip code has been set to the
            //                specified value
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
            // Precondition:  None
            // Postcondition: The package's destination zip code has been returned
            get
            {
                return _destZip;
            }

            // Precondition:  MIN_ZIP <= value <= MAX_ZIP
            // Postcondition: The package's destination zip code has been set to the
            //                specified value
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
            // Precondition:  None
            // Postcondition: The package's length has been returned
            get
            {
                return _length;
            }

            // Precondition:  value > 0
            // Postcondition: The package's length has been set to the
            //                specified value
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
            // Precondition:  None
            // Postcondition: The package's width has been returned
            get
            {
                return _width;
            }

            // Precondition:  value > 0
            // Postcondition: The package's width has been set to the
            //                specified value
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
            // Precondition:  None
            // Postcondition: The package's height has been returned
            get
            {
                return _height;
            }

            // Precondition:  value > 0
            // Postcondition: The package's height has been set to the
            //                specified value
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
            // Precondition:  None
            // Postcondition: The package's weight has been returned
            get
            {
                return _weight;
            }

            // Precondition:  value > 0
            // Postcondition: The package's weight has been set to the
            //                specified value
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
            // Precondition:  None
            // Postcondition: The ground package's zone distance is returned.
            //                The zone distance is the positive difference between the
            //                first digit of the origin zip code and the first
            //                digit of the destination zip code.
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int diff;                             // Calculated zone difference

                diff = (OriginZip / FIRST_DIGIT_FACTOR) - (DestinationZip / FIRST_DIGIT_FACTOR);

                return Math.Abs(diff); // Absolute value in case negative
            }
        }

        // Precondition:  None
        // Postcondition: The ground package's cost has been returned
        public double CalcCost()
        {
            const double SIZE_COST_FACTOR = .20;  // Size coefficient in cost equation
            const double WEIGHT_COST_FACTOR = .35; // Weight coefficient in cost equation

            return (SIZE_COST_FACTOR * (Length + Width + Height) + WEIGHT_COST_FACTOR * (ZoneDistance + 1) * Weight);
        }

        // Precondition:  None
        // Postcondition: A String with the ground package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Origin: {OriginZip:D5}{NL}" +
                $"Destination: {DestinationZip:D5}{NL}" +
                $"Length: {Length:N1}{NL}" +
                $"Width: {Width:N1}{NL}" +
                $"Height: {Height:N1}{NL}" +
                $"Weight: {Weight:N1}";
        }
    }
}
