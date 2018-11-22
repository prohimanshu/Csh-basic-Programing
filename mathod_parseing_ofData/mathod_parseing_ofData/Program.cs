using System;
namespace mathod_parseing_ofData
{
    class Program
    {
        static void mthdwithpara(string b,int c)
        {
            Console.WriteLine("i'm in mthdwithpara");
            Console.WriteLine("pars string {0} and number is {1}", b, c);
        }
        static int returntype(int d,int e)
        {
            Console.WriteLine("i'm in returntype");
            return(d*e);
        }
        static void usingstatic()
        {
            Console.WriteLine("i'm in mthod usingstatic");
        }
        static void Main(string[] a)
        {
            Console.WriteLine("i'm on main method and i'm going to usingstatic method");
            usingstatic();
            Console.WriteLine("again i'm on main method body i'm going to mthwitpara");
            mthdwithpara("himanshu", 123);
            Console.WriteLine("i'm back on main method and i'm go to returntype method");
            Console.WriteLine(returntype(123, 321));
            Console.ReadLine();
        }
    }
}
