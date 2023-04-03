using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel
{
    private Address _originAddress;
    private Address _destAddress;

    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        get
        {
            return _originAddress;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentOutOfRangeException($"{nameof(OriginAddress)}",
                    value, $"{nameof(OriginAddress)} must not be null");
            }
            else
                _originAddress = value;
        }
    }

    public Address DestinationAddress
    {
        get
        {
            return _destAddress;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentOutOfRangeException($"{nameof(DestinationAddress)}",
                    value, $"{nameof(DestinationAddress)} must not be null");
            }
            else
                _destAddress = value;
        }
    }

    public abstract decimal CalcCost();

    public override String ToString()
    {
        string NL = Environment.NewLine;

        return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
            $"{DestinationAddress}{NL}Cost: {CalcCost():C}";
    }
}
