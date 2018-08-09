using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMonday
{
    class Gen
    {

        static void Main(String[] n)
        {
            SortedList<string,string> t = new SortedList<string, string>() { {"Ram","Manager" },{"Ravi","Clerk" } };
            t.Add("Jack", "Manager");
            t.Add("Kevin", "Supervisor");
            //t.Add("Jack", "Clerk");
            t.Add("Penn", "Manager");

          //  ICollection<string> k=t.Keys;
          
            foreach (KeyValuePair<string,string> x in t)
                Console.WriteLine("t[{0}]:: {1}", x.Key, x.Value);

            Console.ReadKey();

          /*  SortedSet<int> l = new SortedSet<int>() { 1368,232,2321,122};
            l.Add(1234);
            l.Add(123);
            l.Add(123);
            l.Add(1234);
            l.Add(23);
            l.Add(5000);
            l.Add(18);
            l.Add(2323);
            l.Add(1123);*/
           
            // l = l.FindAll(x=>x>1500);
          // IEnumerable<int> test= l.Where(x => x > 1200);
           /* foreach(int a in l){ 
                Console.WriteLine(a);
            }

            Console.ReadKey();


          /*  ArrayList l = new ArrayList();

            l.Add(12);
            l.Add(null);
            l.Add(12);
            l.Add("Broad");
            l.Add(34);
            l.Insert(1, "Ram");

            foreach(object x in l) {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < l.Count; i++)
                Console.WriteLine(l[i]);

            Console.WriteLine("------------------------------------------");

            List<string> l1 = new List<string>();

            l1.Add("Nick");
            l1.Add("Jack");
            l1.Add("Ram");
            l1.Add(null);

            l1.Insert(1, "Naman");

            foreach (object x in l1)
            {
                Console.WriteLine(x);
            }

            l1[3] = "Robert";

            Console.WriteLine(l1[2]);


            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < l1.Count; i++)
                Console.WriteLine(l1[i]);


            Console.ReadKey();
          /*  Stack s = new Stack();

            s.Push(12);
            s.Push(13);
            s.Push(14);


            foreach (object x in s)
                Console.WriteLine(x);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(s.Pop());
            Console.ReadKey();
            */
        }
    }
}
