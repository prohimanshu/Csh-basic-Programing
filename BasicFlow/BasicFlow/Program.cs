using System;
namespace BasicFlow
{
    class Program
    {
        static void Main (string[] a)
        {
            Console.WriteLine("I'm in Main Class");
            Run();
            Console.WriteLine("Again i'm in class main");
            Console.ReadLine();
        }
        static void Run()
        {
            Console.WriteLine("i'm in sub class 'static void Run'");
        }
    }
    public class Computer
    {
        //Console.WriteLine("i'm in class 'Computer'");
    }
    class Enemy
    {
        //Console.WriteLine("I'm in 'class Enemy'");
    }
}