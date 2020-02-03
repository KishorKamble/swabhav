using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Human h1 = new Human("Kishor",GenderType.Male, 5.3f, 100.00f, 26);
            Console.WriteLine("Before Workout");
            PrintInfo(h1);
            h1.Workout();
            Console.WriteLine("After Workout");
            PrintInfo(h1);

            Human h2 = new Human("Vishal", GenderType.Male);
            Console.WriteLine("Before Workout");
            PrintInfo(h2);
            h2.Workout();
            Console.WriteLine("After Workout");
            PrintInfo(h2);


            Console.ReadLine();
        }

        public static void PrintInfo(Human h1)
        {
            Console.WriteLine("Name - " + h1.Name);
            Console.WriteLine("Gender - " + h1.Gender);
            Console.WriteLine("Height - " + h1.Height);
            Console.WriteLine("Weight - " + h1.Weight);
            Console.WriteLine("Age - " + h1.Age);

            Console.WriteLine("");
        }
    }
}
