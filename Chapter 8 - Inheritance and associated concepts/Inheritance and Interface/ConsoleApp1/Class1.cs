using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        protected int sno;
        protected string name;
        protected int objectCount;
        protected static int nob;

        public Person()
        {
            nob++;
            objectCount = nob;
            Console.WriteLine("Message...!!!");
            this.sno = 12;
            this.name = "Rajesh";
        }

        public Person(int sno, string name)
        {
            nob++;
            objectCount = nob;
            this.sno = sno;
            this.name = name;
        }

        public void setPerson(String name)
        {
            this.name = name;
        }

        public void setPerson(String name, int sno)
        {
            this.sno = sno;
            this.name = name;
        }
        public virtual void Display()
        {

            Console.WriteLine(sno + " " + name);
        }

        public void showCounters()
        {
            Console.WriteLine("object count:" + objectCount);
            Console.WriteLine("nob: " + nob);
        }

        public static void NumberOfObjs()
        {

            Console.WriteLine("nob: " + nob);
        }
    }

    class Indian : Person
    {

        int nationalid;
        String state;

        public Indian(int sno, string name, int nationalid, String state) : base(sno, name)
        {

            this.nationalid = nationalid;
            this.state = state;
        }

        public override
            void Display()
        {
            base.Display();
            Console.WriteLine(nationalid + "  " + state);
        }

    }
    class Class1
    {
        /* static void Main(string[] n) {
             Indian obj = new Indian(12,"Rajeev",1232,"Tamil Nadu");
             obj.showCounters();
             obj.Display();

             Person test = obj;

            // Indian test1 = test;
             Console.WriteLine("--------------------------------------------");
             test.Display();

             Console.ReadKey();



           /*  Person p = new Person();
             Person p1 = new Person(13, "Ravi");

             p.Display();
             Console.WriteLine("-------------------------------");
             p.setPerson("Raghu");
             p.Display();
             Console.WriteLine("-------------------------------");

             p1.Display();
             p1.setPerson("Rajan", 12);
             Console.WriteLine("-------------------------------");
             p1.Display();

             Console.WriteLine("-------------------------------");
             p.showCounters();
             Console.WriteLine("-------------------------------");
             p1.showCounters();

             Console.ReadKey();

            // p1.NumberOfObjs();
             Person.NumberOfObjs();*/
        /*    }
        }*/
    }
}
