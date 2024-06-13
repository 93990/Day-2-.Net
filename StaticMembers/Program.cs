using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(Class1.static_i);
            Class1.static_i = 1000;
            Class1.static_Display();
            Class1.Static_P1 = 10;
            Class1 o1 = new Class1();
            o1.i = 100;
            o1.Display();
            Class1 o2 = new Class1();
            o2.i = 200;

            Console.ReadLine();
        }
    }
    public class Class1
    {
        public int i;
        //why static variable? - single copy for the class
        public static int static_i;

        //why static function? - no need to create an object of the class, 
        //can be called directly classname.methodname
        public void Display()
        {
            
            Console.WriteLine("display called");
            Console.WriteLine(i);
            Console.WriteLine(static_i);
        }
        public static void static_Display()
        {
            Console.WriteLine("static display called");
            Console.WriteLine(static_i);
            //Console.WriteLine(i);
            //from static method, can only access static member directly
        }
        private int p1;
        public int P1
        {
            set
            {
                if (value <= 100)
                    p1 = value;
                else
                    Console.WriteLine("invalid value for P1");
            }
            get
            {
                return p1;
            }
        }
        private static int static_p1;
        public static int Static_P1
        {
            set
            {
                if (value <= 100)
                    static_p1 = value;
                else
                    Console.WriteLine("invalid value for P1");
            }
            get
            {
                return static_p1;
            }
        }

        static Class1()
        {
            Console.WriteLine("static cons called");
            Static_P1 = 11;
            static_i = 12;
        }
    }
}

//why static variable - single copy for the class
//why property - validation
//why static property - single copy for the class with validation

//when static cons called - when class is loaded into memory
//when is the class loaded into memory -- first obj is created or static member accessed for the first time
//static cons is implicitly called
//static cons is parameterless, and cannot be overloaded
//static cons is implicitly private and therefore cannot have an access specifier

//TO DO
//create a static class
//can only have static members
//cannot be instantiated
//cannot be used as a base class