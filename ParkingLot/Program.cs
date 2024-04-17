using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();
            
            while (true)
            {
                Console.Write("$ ");
                string input = Console.ReadLine();

                string[] splitInput = input.Split(' ');

                string firstWord = splitInput[0];

                if (firstWord == "create_parking_lot")
                {
                    if (int.Parse(splitInput[1]) <= 0)
                    {
                        Console.WriteLine("Please enter minimum 1 capacity");
                        continue;
                    }

                    parkingLot = new ParkingLot(int.Parse(splitInput[1]));
                    Console.WriteLine($"Created a parking lot with {parkingLot.Capacity} slots");

                }else if (firstWord == "park")
                {
                    if (parkingLot.Capacity == 0)
                    {
                        Console.WriteLine("Please create parking lot first");
                        continue;
                    }
                    
                    string registrationNumber = splitInput[1];
                    string vehicleColor = splitInput[2];
                    string vehicleType = splitInput[3];

                    parkingLot.RegisterParking(new Vehicle(registrationNumber, vehicleType, vehicleColor));

                }else if (firstWord == "leave")
                {
                    if (parkingLot.Capacity == 0)
                    {
                        Console.WriteLine("Please create parking lot first");
                        continue;
                    }
                    
                    int slotNumber = Convert.ToInt32(splitInput[1]);
                    parkingLot.LeaveParking(slotNumber);
                }else if (firstWord == "status")
                {
                    if (parkingLot.Capacity == 0)
                    {
                        Console.WriteLine("Please create parking lot first");
                        continue;
                    }
                    
                    parkingLot.GetAllVehicles();
                }else if (firstWord == "type_of_vehicles")
                {
                    if (parkingLot.Capacity == 0)
                    {
                        Console.WriteLine("Please create parking lot first");
                        continue;
                    }
                    
                    parkingLot.TypeOfVehicle(splitInput[1]);
                }else if (firstWord == "registration_numbers_for_vehicles_with_ood_plate")
                {
                    Console.WriteLine("Plate nomor ganjil");
                }else if (firstWord == "registration_numbers_for_vehicles_with_event_plate")
                {
                    Console.WriteLine("Plate nomor genap");
                } else if (firstWord == "registration_numbers_for_vehicles_with_colour")
                {
                    parkingLot.VehicleRegistrationNumberWithColour(splitInput[1]);
                }else if (firstWord == "slot_numbers_for_vehicles_with_colour")
                {
                    Console.WriteLine("slot nomr sesuai warna mobil");
                }else if (firstWord == "slot_number_for_registration_number")
                {
                    Console.WriteLine("slot nomor sesuai plat nmr");
                }else if (firstWord == "exit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("wrong command");
                }
            }
        }
    }
}