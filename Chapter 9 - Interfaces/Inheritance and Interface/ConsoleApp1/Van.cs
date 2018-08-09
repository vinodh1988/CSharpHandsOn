using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    class Van:Vehicle
    {
        private string purpose;

       public Van(string brand, double price, string purpose) : base(brand, price)
        {
            this.purpose = purpose;
        }
        public override void FixTyre()
        {
            Console.WriteLine("Van Tyre is being fixed");
        }

        public override void FixWheel()
        {
            Console.WriteLine("Wheel of the Van is being fixed");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Van purpose: {0}", purpose);
        }

        public override void AddLubricant()
        {
            Console.WriteLine("Lubricant is applied for Van");
        }

        public override void FillFuel()
        {
            Console.WriteLine("Fuel is being filled for Van");
        }
    }
}

