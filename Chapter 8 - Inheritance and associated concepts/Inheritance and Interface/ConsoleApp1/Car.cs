using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    class Car : Vehicle
    {
        private string carType;

        public Car(string brand, double price, string carType) : base(brand, price) {
            this.carType = carType;
        }
        public override void FixTyre()
        {
            Console.WriteLine("Car Tyre is being fixed");
        }

        public override void FixWheel()
        {
            Console.WriteLine("Wheel of the care is being fixed");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("CarType: {0}", carType);
        }
        public override void AddLubricant()
        {
            Console.WriteLine("Lubricant is applied for Car");
        }

        public override void FillFuel()
        {
            Console.WriteLine("Fuel is being filled for Car");
        }
    }

}
