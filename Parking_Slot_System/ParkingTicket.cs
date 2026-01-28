using System;

//STEP 4 
namespace ParkingLot_System
{
    internal class ParkingTicket
    {
        internal int TicketId { get; }
        internal Vehicle Vehicle { get; }
        internal ParkingSlot Slot { get; }
        internal DateTime EntryTime { get; }
        internal DateTime? ExitTime { get; private set; }
        internal int TotalFee { get; private set; }

        //CONSTRUCTOR
        internal ParkingTicket(int id, Vehicle vehicle, ParkingSlot slot)
        {
            TicketId = id;
            Vehicle = vehicle;
            Slot = slot;
            EntryTime = DateTime.Now;
        }

        internal void CloseTicket()
        {
            ExitTime = DateTime.Now;

            TimeSpan duration = ExitTime.Value - EntryTime;
            int totalMinutes = (int)Math.Ceiling(duration.TotalMinutes);

            //CALCULATEFEE IS POLYMORPHISM
            TotalFee = Vehicle.CalculateFee(totalMinutes);

        }
    }
}

