using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Operator_Overloading
{
   sealed  class Complex
    {
        private int x;
        private int y;
        

        public Complex() { }
        public Complex(int x, int y) {
            this.x = x;
            this.y = y;
           
            
        }

        public static Complex operator+(Complex c1, Complex c2)
         {
            Complex c3 = new Complex();
            c3.x=c1.x+c2.x;
            c3.y=c1.y+c2.y;
            return c3;
            
         }

        public static Complex operator++(Complex c1)
        {
            c1.x++;
            c1.y++;
            return c1;

        }
        public override string ToString()
        {
            return x + "+" + "i" + y;
        }
    }

    class Test : Complex {


    }
}
