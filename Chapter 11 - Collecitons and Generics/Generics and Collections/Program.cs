using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpMonday.Props;
using CSharpMonday.Concepts;
using CSharpMonday.Delegates;
using CSharpMonday.Partial;
using CSharpMonday.Generics;

namespace CSharpMonday
{

    
    class Program
    {


       
        static void Main(String[] n) {

            GeneralStore g = new GeneralStore("Ram");

            GeneralStore g1 = new GeneralStore(23.23);

            Console.WriteLine(g.Data);
            g.Data = 12;

            Console.WriteLine(g.Data);

    

            GenericStore<string> gs = new GenericStore<string>("Ram");

            GenericStore<int> gs1 = new GenericStore<int>(123);

            

            gs.Data = 123;

            gs.setData("Ramu");
            Console.ReadKey();


		}
        
    }

