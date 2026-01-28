using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// STEP 2 
namespace ParkingLot_System
{
    internal class Bus : Vehicle
    {
        internal override string Type => "Bus";
        internal override int RatePerMinute => 10; 
    }
}
