using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRace
{
    class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelForKm;
        private int distance;
        public string Model { get { return this.model; } }
        public decimal FuelLeft { get{ return this.fuelAmount; } }
        public int Distance { get { return this.distance; } }

        public Car(string model,decimal fuelAmount,decimal fuelForKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelForKm = fuelForKm;
            this.distance = 0;
        }

        public void Drive(int distance)
        {
            this.fuelAmount -= distance * this.fuelForKm;
            this.distance += distance;
        }
    }
}
