using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] a)
        {
            int age;
            age = 10;
            Console.WriteLine(age);
            Console.ReadLine();
            double ao=10.5;
            ao++;
            Console.WriteLine($"double after ao++ before a=10.5 ao={ao}");
            float b = 10.6f;
            b++;
            Console.WriteLine("float b=10.6 after b++ b={0}",b);
            Console.WriteLine("=======user read ALU======");
            Console.WriteLine("enter the value for a var");
            double var1, var2;
            var1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for b var");
            var2 = double.Parse(Console.ReadLine());
            Console.WriteLine("a+b={0} \na-b={1} \na*b={2} \na/b={3}",(var1+var2),(var1-var2),(var1*var2),(var1/var2));
            Console.WriteLine("a++={0}", var1++);
            Console.WriteLine($"b--={var2--}");
            Console.WriteLine($"a%b={(var1 % var2)}");
            Console.WriteLine("=====Char ASCII=====-");
            Char alpha;
            int con;
            Console.Write("Enter a single Char=");
            alpha = char.Parse(Console.ReadLine());     //excepction char
            con = alpha;
            Console.WriteLine("ASCII of {0} is {1}",alpha,con);
            Console.WriteLine("=====String Operation====");
            string word1,word2;
            Console.Write("enter the word1=");
            word1=Console.ReadLine();
            Console.Write("enter the word2=");
            word2 = Console.ReadLine();
            Console.WriteLine($"enter by word first is={word1} and Second is={word2}");
            Console.WriteLine($"String Add test ={word1 + word2}");
            Console.WriteLine($"String add new word hello={word1 + " Hello " + word2}");
            Console.WriteLine(word1.ToUpper());
            Console.WriteLine(word2.ToLower());
            Console.WriteLine(word1.GetType());
            Console.WriteLine(con.GetType());
            Console.WriteLine(alpha.GetType());
            Console.WriteLine(ao.GetType());
            Console.ReadLine();
        }
    }
}