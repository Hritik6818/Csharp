
using System;
using System.Collections.Generic;
using System.Linq;

//STEP 5

namespace ParkingLot_System
{
    internal class ParkingLot
    {
        private List<ParkingSlot> slots = new();
        private int ticketCounter = 1;

        internal ParkingLot(int totalSlots)
        {
            for (int i = 1; i <= totalSlots; i++)
                slots.Add(new ParkingSlot(i));
        }

        internal ParkingTicket ParkVehicle(Vehicle vehicle)
        {
            ParkingSlot freeSlot = slots.FirstOrDefault(s => s.IsAvailable);

            if (freeSlot == null)
            {
                Console.WriteLine("❌ Parking Full");
                return null;
            }

            freeSlot.Park(vehicle);
            return new ParkingTicket(ticketCounter++, vehicle, freeSlot);
        }

        internal void ExitVehicle(ParkingTicket ticket)
        {
            ticket.CloseTicket();
            ticket.Slot.Release();

            Console.WriteLine("\n--- BILL DETAILS ---");
            Console.WriteLine($"Vehicle Type : {ticket.Vehicle.Type}");
            Console.WriteLine($"Entry Time   : {ticket.EntryTime}");
            Console.WriteLine($"Exit Time    : {ticket.ExitTime}");
            Console.WriteLine($"Total Fee    : Rs.{ticket.TotalFee}");
        }

        internal void ShowSlotStatus()
        {
            Console.WriteLine("\n--- SLOT STATUS ---");
            foreach (var slot in slots)
            {
                string status = slot.IsAvailable ? "Empty" : $"Occupied ({slot.ParkedVehicle.Type})";
                Console.WriteLine($"Slot {slot.SlotNumber}: {status}");
            }
        }
    }
}

