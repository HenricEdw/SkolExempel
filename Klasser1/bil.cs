using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser1
{
    class Bil
    {
        private string colour;
        private string numberOfDoors;
        private string model;
        private string regNumber;
        private int speed;

        public Bil(string colour, string numberOfDoors, string model, string regNumber, int speed)
        {
            this.colour = colour;
            this.model = model;
            this.numberOfDoors = numberOfDoors;
            this.regNumber = regNumber;
            this.speed = speed;
        }

        public string Drive()
        {
            return $"Jag kör just nu i {speed} km/h!";
        }

        public string GetModel()
        {
            return model;
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
