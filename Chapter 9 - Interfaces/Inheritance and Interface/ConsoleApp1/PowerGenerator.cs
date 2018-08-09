using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    class PowerGenerator : FuelHandler
    {
        public void AddLubricant()
        {
            Console.WriteLine("Lubricant is applied for Power Generator");
        }

        public void FillFuel()
        {
            Console.WriteLine("Fuel is being filled for Power Generator");
        }
    }
}
