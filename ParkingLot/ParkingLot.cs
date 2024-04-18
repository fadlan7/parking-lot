using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void TypeOfVehicle(string vehicleType)
        {
            int count = 0;
            for (int i = 0; i < capacity; i++) 
            { 
                if (vehicles[i].TypeOfVehicle.ToLower() == vehicleType.ToLower() && vehicles[i] != null) 
                { 
                    count++;
                }
            } 
            Console.WriteLine($"{count}");
        }
        
        public void VehicleRegistrationNumberWithColour(string colour)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < capacity; i++) 
            { 
                if (vehicles[i].Colour.ToLower() == colour.ToLower() && vehicles[i] != null) 
                {
                    result.Add(vehicles[i].RegistrationNumber);
                }
            }
            
            StringBuilder sb = new StringBuilder();
            foreach (var vehicle in result)
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(string.Join(", ",vehicle));
            }

            Console.WriteLine(sb.ToString());
        }
        
        public void SlotNumberWithColour(string colour)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < capacity; i++) 
            { 
                if (vehicles[i].Colour.ToLower() == colour.ToLower() && vehicles[i] != null) 
                {
                    result.Add(i + 1);
                }
            }
            
            StringBuilder sb = new StringBuilder();
            foreach (var slot in result)
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(string.Join(", ",slot));
            }

            Console.WriteLine(sb.ToString());
        }
        
        public void SlotNumberWithRegistrationNumber(string regNumber)
        {
            bool isFound = false;
            for (int i = 0; i < capacity; i++) 
            { 
                if (vehicles[i].RegistrationNumber.ToLower() == regNumber.ToLower() && vehicles[i] != null)
                { 
                    Console.WriteLine(i + 1);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Not found");
            }
        }
        
        public void VehicleOddRegistrationNumber()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < capacity; i++) 
            { 
                String removeDashResult = RemoveDash(vehicles[i].RegistrationNumber);
                if (removeDashResult[removeDashResult.Length-1] % 2 != 0)
                {
                    result.Add(vehicles[i].RegistrationNumber);
                }
            }
            
            StringBuilder sb = new StringBuilder();
            foreach (var vehicle in result)
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(string.Join(", ",vehicle));
            }

            Console.WriteLine(sb.ToString());
        }
        
        public void VehicleEvenRegistrationNumber()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < capacity; i++) 
            { 
                String removeDashResult = RemoveDash(vehicles[i].RegistrationNumber);
                if (removeDashResult[removeDashResult.Length-1] % 2 == 0)
                {
                    result.Add(vehicles[i].RegistrationNumber);
                }
            }
            
            StringBuilder sb = new StringBuilder();
            foreach (var vehicle in result)
            {
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(string.Join(", ",vehicle));
            }

            Console.WriteLine(sb.ToString());
        }
        
        private static string RemoveDash(string input)
        {
            int startIndex = input.IndexOf('-') + 1;
            int endIndex = input.LastIndexOf('-');
            return input.Substring(startIndex, endIndex - startIndex);
        }
    }
}