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
    }
}