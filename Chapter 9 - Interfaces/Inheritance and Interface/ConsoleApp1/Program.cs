using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automobiles;

namespace ConsoleApp1
{
    class Program
    {
        
         static void Main(string[] args)
        {

            FuelHandler f;
            Vehicle v = new Car("Tata", 450000.89, "Budget");
            v.Display();
            v.FixWheel();
            v.FixTyre();
            v.FillFuel();
            v.AddLubricant();
           /* f = v;
            f.FillFuel();
            f.AddLubricant();*/
            Console.WriteLine("--------------------------------------");
            v = new Van("Force", 900000.34, "Human Transport");
            v.Display();
            v.FixWheel();
            v.FixWheel();
            f = v;
            f.FillFuel();
            f.AddLubricant();
            Console.WriteLine("--------------------------------------");

            f = new PowerGenerator();
            f.FillFuel();
            f.AddLubricant();
            Console.WriteLine("--------------------------------------");

            f = new SteamEngine();
            f.FillFuel();
            f.AddLubricant();

            Console.ReadKey();
            
        }

        


    }
}
