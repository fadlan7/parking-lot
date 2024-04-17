using System.Collections.Generic;

namespace ParkingLot
{
    public class Vehicle
    {
        private string registrationNumber;
        private string typeOfVehicle;
        private string colour;

        public Vehicle(string registrationNumber, string typeOfVehicle, string colour)
        {
            this.registrationNumber = registrationNumber;
            this.typeOfVehicle = typeOfVehicle;
            this.colour = colour;
        }

        public Vehicle()
        {
        }

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public string TypeOfVehicle
        {
            get { return typeOfVehicle; }
            set { typeOfVehicle = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}