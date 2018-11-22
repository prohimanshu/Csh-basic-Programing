using System;
namespace ArrayTech
{
    class Program
    {
        static void Main(string[] a)
        {
            int[] ara = new int[3];//array length is 3
            ara[0] = 11;
            ara[1] = 22;
            ara[2] = 33;
            Console.WriteLine($"ara[0]={ara[0]}\nara[1]={ara[1]}\nara[2]={ara[2]}\n");
            Console.WriteLine("====2d array===");
            int rw, cm;
            Console.WriteLine("enter the number of row");
            rw = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Number of Col");
            cm = int.Parse(Console.ReadLine());
            int[,] tod = new int[rw,cm];

            for(int i = 0; i<rw; ++i)// read the 2d array
            {
                for(int j = 0; j<cm; ++j)
                {
                    tod[i,j] = Convert.ToInt32(Console.ReadLine());//convert in base 32
                }
            }
            for (int i = 0;i< rw; ++i)
            {
                Console.WriteLine("\n");//for print next line
                for(int j = 0; j < cm; ++j)
                {
                    Console.Write("{0}\t",tod[i, j]);//for tab and print each elements
                }
            }
            Console.ReadLine();
        }
    }
}