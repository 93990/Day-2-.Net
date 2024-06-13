using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            o.seti(1000);
            Console.WriteLine(o.geti());

            o.j = ++o.j + o.j++ - --o.j - o.j--;

            Console.ReadLine();
        }
        static void Main()
        {
            Class2 o = new Class2();
            
            o.I = 100; //set
            Console.WriteLine(o.I); //get

            Console.WriteLine(o.P1);

            o.P2 = 100;
            Console.WriteLine(o.P2);

            Console.ReadLine();
        }
    }

    //using setter and getter --- DONT USE THIS AT ALL
    public class Class1
    {
        //field
        private int i;
        public int j;

        public void seti(int VALUE)
        {
            if(VALUE <= 100)
                i = VALUE;
            else
                Console.WriteLine("invalid value for i");
        }
        public int geti()
        {
            return i;   
        }
    }

    //properties
    public class Class2
    {
        //field
        private int i;
        public int I
        {
            set
            {
                if (value <= 100)
                    i = value;
                else
                    Console.WriteLine("invalid value for i");
            }
            get
            {
                return i;
            }
        }

        //field
        public string S2;

        //property
        private string s;
        public string S
        {
            set { s = value; }
            get { return s; }
        }

        //read only property
        private int p1 = 100;
        public int P1
        {
            get { return p1; }
        }
        //automatic property
        //use this when there are no validations
        //compiler generates the code for set and get
        //compiler generates the private variable
        public int P2 { get; set; }
        public string P3 { get; set; }

    }
}
