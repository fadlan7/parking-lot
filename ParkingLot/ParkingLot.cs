using System;

namespace ParkingLot
{
    public class ParkingLot
    {
        private int capacity;
        private Vehicle[] vehicles;
        private int parkingSlot = 1;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
            vehicles = new Vehicle[capacity];
        }

        public ParkingLot()
        {
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public void RegisterParking(Vehicle vehicle)
        {
            if (parkingSlot <= capacity)
            {
                Console.WriteLine(capacity);
                vehicles[parkingSlot - 1] = vehicle;
                Console.WriteLine($"Allocated slot number: {parkingSlot}");
                parkingSlot++;
            }
            else
            {
                Console.WriteLine("Sorry, parking lot is full");
            }
        }
        
        public void LeaveParking(int parkingSlotNumber)
        {
            if (parkingSlotNumber > 0 && parkingSlotNumber <= parkingSlot)           
            {
                vehicles[parkingSlotNumber - 1] = null;
                    
                if (parkingSlotNumber < parkingSlot)
                {
                    parkingSlot = parkingSlotNumber;
                    Console.WriteLine($"Slot number {parkingSlotNumber} is free");
                }
            } 
        }

        public void GetAllVehicles()
        { 
            Console.WriteLine("Slot No.    Registration No  Type   Colour"); 
            for (int i = 0; i < capacity; i++)
            {
                if (vehicles[i] != null)
                {
                    Console.WriteLine($"{i + 1}     {vehicles[i].RegistrationNumber}    {vehicles[i].TypeOfVehicle}     {vehicles[i].Colour}");
                }
            }
        }
    }
}