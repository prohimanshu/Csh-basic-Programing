
using System;
namespace Return_type_method
{
    class Program
    {
        static void Main(string[] a)
        {
            Console.WriteLine("======return type add sub mul div=======");
            double c = 0, d = 0 ,e = 0;
            Console.Write("enter the value a=");
            c = double.Parse(Console.ReadLine());
            Console.Write("enter the value b=");
            d = double.Parse(Console.ReadLine());
            e = add(c, d);
            Console.WriteLine("i'm in main method and add={0}", e);
            e = sub(c, d);
            Console.WriteLine("i'm on main method and sub={0}", e);
            e = mal(c, d);
            Console.WriteLine("i'm on main method and mal={0}", e);
            e = div(c, d);
            Console.WriteLine("I'm on main method and div={0}", e);
            Console.ReadLine();

        }
        static double add(double a,double b)
        {
            Console.WriteLine("i'm on add method");
            return(a+b);
        }
        static double sub(double f,double g)
        {
            Console.WriteLine("i'm on my sub method");
            return (f - g);
        }
        static double mal(double h,double i)
        {
            Console.WriteLine("i'm on mal method");
            return (h * i);
        }
        static double div(double j,double k)
        {
            Console.WriteLine("im on div method");
            return (j / k);
        }

    }

}