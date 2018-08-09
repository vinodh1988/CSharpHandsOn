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

           
            int[] n = new int[5] {1,2,3,4,5 };
            int[][] twod = new int[2][]; //Jagged Array
            int[,] p = new int[2, 2] { { 1, 2 }, { 3, 4 } };//multi dimensional array

              Console.WriteLine(p[0, 1]);
              Console.WriteLine("----------------------------");

              twod[0] = new int[1];
              twod[1] = new int[2];

              twod[0][0] = 90;

              twod[1][0] = 90;
              twod[1][1] = 20;

              Console.WriteLine(twod[0][0]);
              Console.WriteLine("----------------------------");

         
              foreach (int x in n)
                  Console.WriteLine(x);

              process(n);
              Console.WriteLine("---------------------------------");
              for (int x = 0; x < n.Length; x++)
                  Console.WriteLine(n[x]);*/
            
            Console.WriteLine("sumup(2,3):{0}", sumup(2, 3));
            Console.WriteLine("sumup(2,3,4):{0}",sumup(2,3,4));
            Console.ReadKey();
            
        }

        static void process(int[] n) {
            for (int i = 0; i < n.Length; i++)
            {
                if (i % 2 == 0)
                    n[i] += i;
            }

        }

       static  int sumup(params int[] n) {
            int sum = 0;
            foreach (int x in n)
                sum += x;

            return sum;
        }


    }
}
