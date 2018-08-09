using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    class SteamEngine: FuelHandler
    {
        public void AddLubricant()
        {
            Console.WriteLine("Lubricant is applied for Steam Engine");
        }

        public void FillFuel()
        {
            Console.WriteLine("Fuel is being filled for Steam Engine");
        }
    }
}
