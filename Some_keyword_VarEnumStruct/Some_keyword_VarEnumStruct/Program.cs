using System;

namespace Some_keyword_VarEnumStruct
{
    class Program
    {
        enum Gender { male,femail,gey,lasbian}

        static void Main(string[] a)
        {
            Console.WriteLine("=====Var And Dynamic keyword");
            var test = 10;
            Console.WriteLine(test);
            Console.WriteLine(test.GetType());

            dynamic testa;
            testa = "hello himanshu";
            Console.WriteLine(testa);
            Console.WriteLine(testa.ToUpper());
            Console.WriteLine(testa.ToLower());
            Console.WriteLine(testa.GetType());
            
            Console.WriteLine("====enum test====");
            Console.WriteLine("please enter your Gender 1 for male\n2 for femail\n3 for gey\n4 for lasbian");
            int ind = int.Parse(Console.ReadLine());
            Gender g = (Gender)ind;
            switch (g)
            {
                case Gender.male:
                    Console.WriteLine("i'm {0}", g);
                    break;
                case Gender.femail:
                    Console.WriteLine("i'm {0}", g);
                    break;
                case Gender.gey:
                    Console.WriteLine("i'm {0}", g);
                    break;
                case Gender.lasbian:
                    Console.WriteLine("i'm {0}", g);
                    break;
                default:
                    Console.WriteLine("i'm god");
                    break;
            }
            Console.WriteLine("====Structure test======");
            Student stu = new Student();
            stu.Age = 21;
            stu.Name = "Himanshu Chauhan";
            Console.WriteLine(stu.Age);
            Console.WriteLine(stu.Name);
            stu.display();
            Console.ReadLine();
        }
        struct Student{
            public int Age;
            public string Name;
            public void display()
            {
                Console.WriteLine("i'm in side of struct method");
            }
        }
    }
}
