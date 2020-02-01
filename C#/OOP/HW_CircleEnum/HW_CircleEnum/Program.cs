using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CircleEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            Circle obj = new Circle();
            obj.radius = 2.5f;
            obj.color = BorderColor.RED;

            Console.WriteLine("Radius - " + obj.radius);
            Console.WriteLine("Circle Area - " + obj.CalculateArea);
            Console.WriteLine("Perimeter - " + obj.Perimeter);
            Console.WriteLine("Color Style - " + obj.color);



            Console.ReadLine();



        }



    }
}
