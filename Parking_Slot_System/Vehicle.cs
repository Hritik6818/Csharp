using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// STEP 1 

namespace ParkingLot_System
{
    internal abstract class Vehicle
    {
        internal abstract int RatePerMinute { get; }
        internal abstract string Type { get; }

        internal int CalculateFee(int minutes)
        {
            return minutes * RatePerMinute;
        }
    }
}

