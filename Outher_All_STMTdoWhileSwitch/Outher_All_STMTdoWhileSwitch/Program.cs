using System;
namespace Outher_All_STMTdoWhileSwitch
{
    class Program
    {
        static void Main(string[] a)
        {
            Console.WriteLine("======Switch STMT======");
            string sel;
            Console.WriteLine("Please enter a number bw 1-4");
            sel = Console.ReadLine();
            switch (sel)
            {
                case "1":
                    Console.WriteLine("i'm good boy");
                    break;
                case "2":
                    Console.WriteLine("i'm not a good Boy");
                    break;
                case "3":
                    Console.WriteLine("you are not a good person");
                    break;
                case "4":
                    Console.WriteLine("jay hind");
                    break;
                default:
                    Console.WriteLine("Retry please renter 1-4");
                    break;
            }
            Console.WriteLine("======while loop Test=======");
            Console.WriteLine("Please Enter a number for table");
            int i=1, j;
            j = int.Parse(Console.ReadLine());
            while (i<10)
            {
                i++;
                Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
            }
            Console.WriteLine("====Do While Loop Test=====");
            int k = 1;
            do
            {
                Console.Write(k);
                k++;
            } while (k<=10);
            Console.WriteLine("=====for each loop new testing of loop====");
            int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //number of loop is 9
            foreach(int m in myarray)
            {
                Console.WriteLine("item");
            }
            Console.ReadLine();
        }
    }
}
