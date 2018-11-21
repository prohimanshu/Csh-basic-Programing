using System;
namespace If_Else
{
    class Program
    {
        static void Main(string[] a)
        {
            double var1, var2;
            if (true)
            {
                Console.WriteLine("if value true then execute");
            }
            else
            {
                //if are not true then exe the else
            }
            Console.WriteLine("===operator===");
            Console.Write("enter the value for a=");
            var1 = double.Parse(Console.ReadLine());
            Console.Write("enter the value for b=");
            var2 = double.Parse(Console.ReadLine());

            if (var1 > var2)
            {
                Console.WriteLine("a is big");
            }
            else
            {
                Console.WriteLine("b is big");
            }
            if (var1 <=var2)
            {
                Console.WriteLine("b is eql or big");
            }
            else
            {
                Console.WriteLine("a is eql or big");
            }
            if (var1 == var2)
            {
                Console.WriteLine("a and b is eql");
            }
            if (var1 != var2)
            {
                Console.WriteLine("a and b not eql");
            }
            Console.WriteLine("====if else if using comp 3 number=====");
            double ab=0, b=0, c=0;
            Console.Write("enter the first value a=");
            ab = double.Parse(Console.ReadLine());
            Console.Write("enter the Second Value b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("enter thr thrd value c=");
            c = double.Parse(Console.ReadLine());
            if (ab < b && ab < c)
            {
                Console.WriteLine("a is small");
            }
            else if (b < ab && b < c)
            {
                Console.WriteLine("b is small");
            }
            else if (c < ab && c < b)
            {
                Console.WriteLine("c is small");
            }
            Console.WriteLine("===conditionl stmt");
            string msg = (2 > 4) ? "2 is big" : "4 is big";
            Console.WriteLine("after conditionl stmt mst is ={0}",msg);
            Console.ReadLine();
        }
        
    }

}