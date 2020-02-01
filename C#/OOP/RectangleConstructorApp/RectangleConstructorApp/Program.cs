using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
           //rectangle.Width = 100;
            printInfo(rectangle);
            printInfo(new Rectangle(100,200));
            Console.ReadLine();
        }

        public static void printInfo(Rectangle rect)
        {
            Console.WriteLine("Width - " + rect.Width);
            Console.WriteLine("Height - " + rect.Height);
            Console.WriteLine("Area - " + rect.Area);
          
            Console.WriteLine("");
        }
    }
}
