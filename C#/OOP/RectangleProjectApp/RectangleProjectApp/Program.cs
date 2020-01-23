using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            printInfo(obj);
            obj.Width = -10;
            obj.Height = 234;
            
            Console.WriteLine("Width : " + obj.Width);
            Console.WriteLine("height : " + obj.Height);
            Console.WriteLine("Area : " + obj.Area);
                      
            Console.WriteLine("Using Print Info");
            printInfo(obj);
            printInfo(new Rectangle());
            // printInfo(null);
            Console.WriteLine(new Rectangle().Area);
            Console.ReadLine();
        }

        public static void printInfo(Rectangle rect) 
        {
            Console.WriteLine("Width : " + rect.Width);
            Console.WriteLine("height : " + rect.Height);
            Console.WriteLine("Area : " + rect.Area);
        }

    }
}
