using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            Rectangle obj = new Rectangle();
            obj.Width = 10;
            obj.Height = 20;
            obj.Border = BorderOptions.SINGLE;

            Console.WriteLine("Width - " + obj.Width);
            Console.WriteLine("Height - " + obj.Height);
            Console.WriteLine("Area - " + obj.Area);
            Console.WriteLine("Border Style - " + obj.Border);

           

            Console.ReadLine();

        }
 
    }
}
