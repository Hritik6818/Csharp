using System;


// STEP 3
namespace ParkingLot_System
{
    internal class ParkingSlot
    {
        internal int SlotNumber { get; }
        internal bool IsAvailable { get; private set; }
        internal Vehicle ParkedVehicle { get; private set; }

        //CONSTRUCTOR 
        internal ParkingSlot(int number)
        {
            SlotNumber = number;
            IsAvailable = true;
        }

        internal void Park(Vehicle vehicle)
        {
            ParkedVehicle = vehicle;
            IsAvailable = false;
        }

        internal void Release()
        {
            ParkedVehicle = null;
            IsAvailable = true;
        }

    }
}


