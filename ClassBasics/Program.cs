using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            int ans = 0;
            
            //positional parameters
            ans = o.Add(10, 20, 30);

            //named parameters
            ans = o.Add(a: 10, b: 20, c: 30);
            ans = o.Add(c: 30, a: 10, b: 20);
            ans = o.Add(c: 30, a: 10);
            ans = o.Add(c: 30);
            Console.WriteLine(ans);
            Console.ReadLine();     
        }
        static void Main()
        {
            Class1 o = new Class1();
            o.LocalFunctions();
            Console.ReadLine();
        }
    }

    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        //function overloading
        public void Display(string s)
        {
            Console.WriteLine("Display" + s);
        }
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //default value for a parameter
        public int Add(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        public void LocalFunctions()
        {
            int i = 100;
            Show();
            Func2();
            //local funcs can only be called from the function in which they have been defined
            //no access specifier
            void Show()
            {
                //local funcs can access variables defined in the outer function
                Console.WriteLine("Show" + i);
            }
            void Func2()
            {
                Console.WriteLine("func2");  
            }

        }
    }
}
