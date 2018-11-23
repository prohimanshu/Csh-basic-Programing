using System;

namespace Call_by_Ref_diffBwRefAndOutKeyword
{
    class Program
    {
        static void Main(string[] a)
        {
            Console.WriteLine("=====using out keyword=====");
            int value;
            Console.WriteLine("i'm in main class and value not mension");
            Passbyout(out value);
            Console.WriteLine("i'm back on my main method value {0}", value);
            
            Console.WriteLine("====== using ref keyword=====");
            int val=10;//error if not ib=nclude a value
            Console.WriteLine("i'm test a erf keyword and i'm in main method val={0}", val);
            Passbyref(ref val);
            Console.WriteLine("i'm back in my main method and val={0}",val);
            Console.ReadLine();
        }

        static void Passbyout(out int myvalue)
        {
            myvalue = 10;
            Console.WriteLine("i'm in Passbyout method and passvalue is={0}",myvalue);
        }
        static void Passbyref(ref int refvalue)
        {
            refvalue=20;
            Console.WriteLine("i'm in method Passbyref and pass value is={0}",refvalue);
        }
    }
}
