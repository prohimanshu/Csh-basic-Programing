using System;
namespace method_passByValueAndPassByRefrance
{
    class Program
    {
        static void byvalue(int value)
        {
            value += 5;
            Console.WriteLine("i'm in byvalue method abc val {0}",value);
        }
        static void byref(ref int val)
        {
            val += 5;
            Console.WriteLine("i'm in byref method {0}", val);
        }
        static void Main(string[] a)
        {
            Console.WriteLine("=======Pass by value=======");
            int abc=10;
            Console.WriteLine("i'm in main method and value is {0}",abc);
            byvalue(abc);
            Console.WriteLine("i'm in main method and value of abc after pass by value {0}", abc);
            Console.WriteLine("====pass by ref========");
            abc = 10;
            Console.WriteLine("i'm in main method and before value pass by ref {0}",abc);
            byref(ref abc);
            Console.WriteLine("i'm back on main method and valude of abc is {0}", abc);
        }
    }
}
