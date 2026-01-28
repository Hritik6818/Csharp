using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// STEP 2 

namespace ParkingLot_System
{
    internal class Bike : Vehicle
    {
        internal override string Type => "Bike";
        internal override int RatePerMinute => 3;
    }
}
