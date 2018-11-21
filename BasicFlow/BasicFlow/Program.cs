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
        static void Run()//static declayer method
        {
            Console.WriteLine("i'm in sub class 'static void Run'");
        }
    }
    public class Computer// class out of scope of main class require static declayer
    {
        //Console.WriteLine("i'm in class 'Computer'");
    }
    class Enemy//again out of scope again  require 
    {
        //Console.WriteLine("I'm in 'class Enemy'");
    }
}