using System;
 

namespace OverloadedApp
{
    class OverloadedApp
    {

        static void Main(string[] args)
        {
            double dblObj = 10.55;
            float bobjFl = 10.55555f;

            Console.WriteLine("Hello");
            Console.WriteLine(dblObj);
            Console.WriteLine('#');
            Console.WriteLine(55.21f);
            Console.WriteLine(true);

            

            PrintInfo("Techlab"); 
            PrintInfo(12.89f);
            PrintInfo('c');
            PrintInfo(14.678d);
            PrintInfo(false);


            Console.Read();
        }

        static void PrintInfo(string test1) {
            Console.WriteLine(test1);
                }

        static void PrintInfo(double test2)
        {
            Console.WriteLine(test2);
        }

        static void PrintInfo(char test3)
        {
            Console.WriteLine(test3);
        }

        static void PrintInfo(float test4)
        {
            Console.WriteLine(test4);
        }
            
      static void PrintInfo(bool test5)
        {
            Console.WriteLine(test5);
        }
    }
}
