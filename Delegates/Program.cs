using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int Cal(int a, int b);
    delegate void Print(string s);
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            //Cal cal = new Cal(Add);
            Cal cal = Add;
            uint c = (uint)cal.Invoke(a, b);
            Console.WriteLine(c);

            Print print;
            print = PrintToConsol;
            print += PrintToEvent;
            print("Msg");//multicast Delegates
        }

        static void PrintToConsol(string msg)
        {
            Console.WriteLine("Print to Consol "+msg);
        }

        static void PrintToEvent(string msg) { Console.WriteLine("Print to Event "+msg);}

        static int Add(int x, int y)
        {
            Console.WriteLine("Add");
            return x + y;
        }

        static int Sub(int x, int y)
        {
            Console.WriteLine("Sub");
            return x - y;
        }
    }
}
