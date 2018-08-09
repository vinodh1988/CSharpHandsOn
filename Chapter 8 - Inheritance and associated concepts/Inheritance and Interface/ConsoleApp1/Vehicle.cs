using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
  abstract  class Vehicle:FuelHandler
    {
        protected string brand;
        protected double price;

        public Vehicle(string brand, double price) {
            this.brand = brand;
            this.price = price;
        }

        public abstract void AddLubricant();

        public virtual void Display() {
            Console.WriteLine(this.brand + " " + this.price);
        }

        public abstract void FillFuel();
        abstract public void FixTyre();
        abstract public void FixWheel();
    }
}
