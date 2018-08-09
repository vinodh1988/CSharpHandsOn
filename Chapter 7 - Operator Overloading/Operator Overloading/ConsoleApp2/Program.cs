using System;
using ConsoleApp2.Operator_Overloading;

namespace ConsoleApp2
{
    class Program
    {
        public override string ToString()
        {
            return "Overriden copy";
        }
        static void Main(string[] args)
        {
            
            Complex c = new Complex(12,13);
            Complex c1 = new Complex(33, 23);
            Console.WriteLine(c);
            Console.WriteLine(c1);

            Complex c3 = c1 + c;



            Console.WriteLine(c3);
            c1=c3++;
            Console.WriteLine(c3);
            Console.WriteLine(c1);
     
            Console.ReadKey();
        }
    }
}
