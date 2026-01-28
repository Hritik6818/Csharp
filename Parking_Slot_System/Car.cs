using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// STEP 2 
namespace ParkingLot_System
{
    internal class Car : Vehicle
    {
        internal override string Type => "Car";
        internal override int RatePerMinute => 6; // ₹1 per minute
    }
}
