using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Circle_App
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Circle objSmall = new Circle();
            objSmall.SetRadius(1.2f);
            objSmall.SetColor("GrEEn");   
            PrintInfo(objSmall);

            Console.WriteLine("");
            Console.WriteLine("");

            Circle objBig = new Circle();
            objBig.SetRadius(2.4f);
            objBig.SetColor("jnj kjn kjnj n");
            PrintInfo(objBig);

            Console.ReadLine();

        }

        public static void PrintInfo(Circle clTmp)
        {

            Console.WriteLine("Radius = " + clTmp.GetRadius());
            Console.WriteLine("Color = " + clTmp.GetColor());

            Console.WriteLine("Circle Area " + clTmp.CalculateArea());
            Console.WriteLine("Circle Perimeter " + clTmp.Perimeter());
        }

    }
}
