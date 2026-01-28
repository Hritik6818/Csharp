
using System;
using System.Collections.Generic;

//STEP 6

namespace ParkingLot_System
{
    internal class Program
    {
        static void Main()
        {
            ParkingLot parkingLot = new ParkingLot(5);
            Dictionary<int, ParkingTicket> tickets = new();

            while (true)
            {
                Console.WriteLine("\n1. Park Vehicle");
                Console.WriteLine("2. Exit Vehicle");
                Console.WriteLine("3. Slot Status");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Bike  2. Car  3. Bus");
                        int v = int.Parse(Console.ReadLine());

                        Vehicle vehicle = v switch
                        {
                            1 => new Bike(),
                            2 => new Car(),
                            3 => new Bus(),
                            _ => null
                        };

                        var ticket = parkingLot.ParkVehicle(vehicle);
                        if (ticket != null)
                        {
                            tickets[ticket.TicketId] = ticket;
                            Console.WriteLine($"✅ {vehicle.Type} parked | TicketId: {ticket.TicketId}");
                        }
                        break;

                    case 2:
                        Console.Write("Enter TicketId: ");
                        int id = int.Parse(Console.ReadLine());

                        if (!tickets.ContainsKey(id))
                        {
                            Console.WriteLine("❌ Invalid Ticket");
                            break;
                        }

                        parkingLot.ExitVehicle(tickets[id]);
                        tickets.Remove(id);
                        break;

                    case 3:
                        parkingLot.ShowSlotStatus();
                        break;

                    case 4:
                        return;
                }
            }
        }
    }
}
